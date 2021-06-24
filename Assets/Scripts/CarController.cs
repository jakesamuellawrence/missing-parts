using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Scripting;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

[RequireComponent(typeof(Rigidbody2D))]
public class CarController : MonoBehaviour {

    public float accelerateForce;
    public float brakingForce;
    public float reversingForce;
    public float speedToTurnRatio;
    public float minTraction;
    public float maxTraction;
    public float tractionGraphStretcher;
    public float handbrakeTractionModifier;
    public float stopThreshold;

    public bool wrecked = false;
    public bool parked = false;

    private DefectType defect;

    private bool isAccelerating;
    private bool isBraking;
    private bool isReversing;
    private bool isHandbraking;
    private float turning;

    private Rigidbody2D rb;
    private Collider2D collider2d;
    private InputActions inputs;
    private SpriteRenderer spriteRenderer;

    public float traction {
        get {
            return (float)(-(maxTraction - minTraction) * Math.Tanh(ForwardsVelocity.magnitude / tractionGraphStretcher) + maxTraction);
        }
    }

    public bool goingForwards {
        get {
            float forwards_scalar = Vector2.Dot(rb.velocity, transform.up);
            return forwards_scalar > 0;
        }
    }

    public bool goingBackwards {
        get {
            float backwards_scalar = Vector2.Dot(rb.velocity, transform.up);
            return backwards_scalar < 0;
        }
    }

    public bool stopped {
        get {
            return rb.velocity.magnitude < stopThreshold;
        }
    }

    public void GiveDefect(DefectType defect) {
        this.defect = defect;
        if (defect == DefectType.None) {
            return;
        } else if (defect == DefectType.AlwaysAccel) {
            brakingForce *= 2f;
            stopThreshold *= 2f;
        } else if (defect == DefectType.NoAccel) {
            rb.drag = 0.25f;
            rb.AddForce(transform.up * accelerateForce * 0.5f, ForceMode2D.Impulse);
        } else if (defect == DefectType.NoLeft) {
            speedToTurnRatio *= 1.5f;
        } else if (defect == DefectType.NoRight) {
            speedToTurnRatio *= 1.5f;
        } else if (defect == DefectType.NoBrake) {
            rb.drag = 1.2f;
        } else if (defect == DefectType.NoTraction) {
            tractionGraphStretcher = 1f;
            rb.drag = 0.1f;
            //accelerateForce *= 1.2f;
        } else if (defect == DefectType.PoorTurning) {
            speedToTurnRatio *= 0.3f;
        }
    }

    private void Awake() {
        rb = GetComponent<Rigidbody2D>();
        collider2d = GetComponent<Collider2D>();
        inputs = new InputActions();
        spriteRenderer = GetComponentInChildren<SpriteRenderer>();

        inputs.Driving.Accelerate.started += context => StartAccelerate();
        inputs.Driving.Accelerate.canceled += context => StopAccelerate();
        inputs.Driving.Brake.started += context => StartBrake();
        inputs.Driving.Brake.canceled += context => StopBrake();
        inputs.Driving.Turning.performed += context => UpdateTurning(context.ReadValue<float>());
        inputs.Driving.Turning.canceled += context => UpdateTurning(context.ReadValue<float>());
        inputs.Driving.Handbrake.started += context => StartHandbrake();
        inputs.Driving.Handbrake.canceled += contex => StopHandbrake();

        if (GameManager.instance.nextDefect != DefectType.NoAccel) {
            rb.velocity = transform.up * accelerateForce * 0.3f;
        }
    }

    private void OnEnable() {
        inputs.Driving.Enable();
    }
    private void OnDisable() {
        inputs.Driving.Disable();
    }

    private void StartAccelerate() {
        if (goingBackwards) {
            isBraking = true;
        } else {
            isAccelerating = true;
        }
    }
    private void StopAccelerate() {
        isBraking = false;
        isAccelerating = false;
    }

    private void StartBrake() {
        if (goingForwards) {
            isBraking = true;
        } else {
            isReversing = true;
        }
    }
    private void StopBrake() {
        isBraking = false;
        isReversing = false;
    }

    private void StartHandbrake() {
        isHandbraking = true;
        if (defect != DefectType.NoTraction) {
            maxTraction *= handbrakeTractionModifier;
        }
    }
    private void StopHandbrake() {
        isHandbraking = false;
        if (defect != DefectType.NoTraction) {
            maxTraction /= handbrakeTractionModifier;
        }
    }

    private void UpdateTurning(float turning) {
        if (defect == DefectType.NoLeft && turning < 0) {
            turning = 0;
        } else if (defect == DefectType.NoRight && turning > 0) {
            turning = 0;
        }

        this.turning = turning;
    }

    private void SubmitParking() {
        Collider2D[] collisions = new Collider2D[1];
        ContactFilter2D filter = new ContactFilter2D();
        collider2d.OverlapCollider(filter.NoFilter(), collisions);
        if (collisions[0] != null) {
            parked = true;
            spriteRenderer.color = Color.green;
        } else {
            spriteRenderer.color = Color.yellow;
        }
        TurnIntoObstacle();

        GameManager.instance.EndRound();
    }

    public void TurnIntoObstacle() {
        if (rb.bodyType != RigidbodyType2D.Kinematic) {
            rb.velocity = Vector2.zero;
            rb.angularVelocity = 0;
            rb.bodyType = RigidbodyType2D.Kinematic;
            this.enabled = false;
        }
    }

    public void Wreck() {
        Debug.Log("Wrecking a car!");
        parked = false;
        wrecked = true;
        spriteRenderer.color = Color.red;
        TurnIntoObstacle();
    }

    private void OnCollisionEnter2D(Collision2D other) {
        if (this.enabled) {
            Debug.Log("Handling collision event");

            Wreck();

            CarController otherCar = other.collider.GetComponent<CarController>();

            if (otherCar != null) {
                otherCar.Wreck();
            }

            GameManager.instance.EndRound();
        }
    }

    private void FixedUpdate() {

        if (rb.velocity.magnitude < stopThreshold) {
            rb.velocity = Vector2.zero;
        }

        if (isHandbraking && stopped) {
            SubmitParking();
        }

        if ((isBraking || isHandbraking) && !stopped && !(defect == DefectType.NoBrake)) {
            rb.AddForce(-ForwardsVelocity.normalized * brakingForce);
        } else if ((isAccelerating || (defect == DefectType.AlwaysAccel)) && !isBraking && !(defect == DefectType.NoAccel)) {
            rb.AddForce(transform.up * accelerateForce);
        } else if (isReversing && !(defect == DefectType.NoAccel)) {
            rb.AddForce(-transform.up * reversingForce);
        }

        float turning_to_use = turning;

        float turnAmount = turning_to_use * speedToTurnRatio * ForwardsVelocity.magnitude;
        if (goingForwards) {
            rb.angularVelocity = -turnAmount;
        } else if (goingBackwards) {
            rb.angularVelocity = turnAmount;
        }

        float R1 = RightVelocity.magnitude;
        float R2 = (RightVelocity * (1 - traction)).magnitude;
        float F1 = ForwardsVelocity.magnitude;
        float F2 = (float)Math.Sqrt((Math.Pow(F1, 2) + Math.Pow(R1, 2)) - Math.Pow(R2, 2));

        rb.velocity = ForwardsVelocity.normalized * F2 + RightVelocity.normalized * R2;

    }

    private Vector2 ForwardsVelocity {
        get {
            return transform.up * Vector2.Dot(rb.velocity, transform.up);
        }
    }

    private Vector2 RightVelocity {
        get {
            return transform.right * Vector2.Dot(rb.velocity, transform.right);
        }
    }

}
