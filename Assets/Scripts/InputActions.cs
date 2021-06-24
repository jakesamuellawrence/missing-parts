// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/InputActions.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @InputActions : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @InputActions()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputActions"",
    ""maps"": [
        {
            ""name"": ""Driving"",
            ""id"": ""ae9bbb37-1192-4cbe-b8c0-7d7f1f348539"",
            ""actions"": [
                {
                    ""name"": ""Accelerate"",
                    ""type"": ""Value"",
                    ""id"": ""999bd553-dd25-43e6-a86d-0f6f5e379686"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Brake"",
                    ""type"": ""Value"",
                    ""id"": ""e0e88bec-3e65-4a4b-9fc6-8cd7b3f14223"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Turning"",
                    ""type"": ""Value"",
                    ""id"": ""73a4bcca-fa28-478e-91d2-32c374ea6911"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": ""AxisDeadzone"",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Handbrake"",
                    ""type"": ""Button"",
                    ""id"": ""d3d5b6c5-4c86-4360-8c86-bd2f40401717"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": ""AxisDeadzone"",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""415baf0c-0bef-4bef-8253-db0a48f692c1"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Accelerate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4d0ed16a-83c6-434e-8b29-86cd7500c84c"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Accelerate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1cc3d1d0-d432-47a5-bd21-1674fff6fd28"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Accelerate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2589a8a5-ead8-47e1-a282-b6f7b507c319"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Accelerate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d753474c-86e5-4e16-b586-cec34e0dba04"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Brake"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a246c6e6-34ff-4421-8dca-1696ccd68dd8"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Brake"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""871d74a2-fce6-4608-9f22-92f95e5eb60d"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Brake"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2c7ae9e7-2a35-42b7-8124-235f2d8c9cc8"",
                    ""path"": ""<Gamepad>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Brake"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""A/D"",
                    ""id"": ""7fcea53f-f289-4823-bc6c-afbdd6ce90c6"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Turning"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""5e3ea424-66f8-41e2-a9c8-89c5aca5a41c"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Turning"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""41539938-e759-413c-ba4d-8938c6ae8ae4"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Turning"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Left/Right arrows"",
                    ""id"": ""829a81b6-1435-42f3-bb20-0c2b03bd1998"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Turning"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""6c4cae82-b715-4d0e-8ad0-036bc811f96c"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Turning"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""02bd5de1-296e-4112-a3e2-457ecdaeeba3"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Turning"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""analog stick"",
                    ""id"": ""4e9b776a-cd54-43e8-8fce-e9ae3a9ee8e4"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Turning"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""f3116681-e7f4-4ae6-a1b7-0cf6c19dede9"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Turning"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""0b300b64-efd8-4ec8-bb57-a276d08e5d0d"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Turning"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""DPad"",
                    ""id"": ""657153b5-32ca-4ff6-8385-a49f77a283f5"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Turning"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""1776ac0c-a6ab-4a09-ab89-2c450fb2bff9"",
                    ""path"": ""<Gamepad>/dpad/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Turning"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""1bb47934-6897-441e-b63d-5a27297daf75"",
                    ""path"": ""<Gamepad>/dpad/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Turning"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""01403940-85c0-4036-a25c-89f262d7ce0f"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Handbrake"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1ccc2698-ccb1-4831-9d4c-b4982932889b"",
                    ""path"": ""<Gamepad>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Handbrake"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""BetweenRounds"",
            ""id"": ""5bd277aa-c9e2-4166-ae5d-4274d9097528"",
            ""actions"": [
                {
                    ""name"": ""SpawnNewCar"",
                    ""type"": ""Button"",
                    ""id"": ""a206bebb-d7ed-4a34-a9e3-958e145f5754"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""51337b3e-3533-40ad-be3e-380dcae4bce6"",
                    ""path"": ""<Keyboard>/r"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""SpawnNewCar"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""85bfbd80-8fdd-45af-af1d-d4b990e0cb6d"",
                    ""path"": ""<Gamepad>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""SpawnNewCar"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Menus"",
            ""id"": ""72eb1dce-1e30-4288-b208-ce455126bd43"",
            ""actions"": [
                {
                    ""name"": ""Escape"",
                    ""type"": ""Button"",
                    ""id"": ""8c535fc8-fa0a-447d-9da0-842a88ad3d94"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Accept"",
                    ""type"": ""Button"",
                    ""id"": ""7d5b6098-8b13-43d6-9215-b57cd1885048"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MousePosition"",
                    ""type"": ""PassThrough"",
                    ""id"": ""5e81b548-ef09-4f30-a520-70869e212809"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""990233ab-e9ff-4801-8925-53665c61e1cb"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Escape"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2de92ab2-bb70-44fb-859e-dbbf0b6e4035"",
                    ""path"": ""<Gamepad>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Escape"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""746b404d-a3a8-4fae-9618-27f8708a701c"",
                    ""path"": ""<Keyboard>/enter"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Accept"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""53468fdf-6981-40a8-ace7-b39b8501ba63"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Accept"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""de2b498e-6864-4b08-82d4-4ad3d7c7e6df"",
                    ""path"": ""<Mouse>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""MousePosition"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Keyboard&Mouse"",
            ""bindingGroup"": ""Keyboard&Mouse"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Mouse>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Gamepad"",
            ""bindingGroup"": ""Gamepad"",
            ""devices"": [
                {
                    ""devicePath"": ""<Gamepad>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // Driving
        m_Driving = asset.FindActionMap("Driving", throwIfNotFound: true);
        m_Driving_Accelerate = m_Driving.FindAction("Accelerate", throwIfNotFound: true);
        m_Driving_Brake = m_Driving.FindAction("Brake", throwIfNotFound: true);
        m_Driving_Turning = m_Driving.FindAction("Turning", throwIfNotFound: true);
        m_Driving_Handbrake = m_Driving.FindAction("Handbrake", throwIfNotFound: true);
        // BetweenRounds
        m_BetweenRounds = asset.FindActionMap("BetweenRounds", throwIfNotFound: true);
        m_BetweenRounds_SpawnNewCar = m_BetweenRounds.FindAction("SpawnNewCar", throwIfNotFound: true);
        // Menus
        m_Menus = asset.FindActionMap("Menus", throwIfNotFound: true);
        m_Menus_Escape = m_Menus.FindAction("Escape", throwIfNotFound: true);
        m_Menus_Accept = m_Menus.FindAction("Accept", throwIfNotFound: true);
        m_Menus_MousePosition = m_Menus.FindAction("MousePosition", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }

    // Driving
    private readonly InputActionMap m_Driving;
    private IDrivingActions m_DrivingActionsCallbackInterface;
    private readonly InputAction m_Driving_Accelerate;
    private readonly InputAction m_Driving_Brake;
    private readonly InputAction m_Driving_Turning;
    private readonly InputAction m_Driving_Handbrake;
    public struct DrivingActions
    {
        private @InputActions m_Wrapper;
        public DrivingActions(@InputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Accelerate => m_Wrapper.m_Driving_Accelerate;
        public InputAction @Brake => m_Wrapper.m_Driving_Brake;
        public InputAction @Turning => m_Wrapper.m_Driving_Turning;
        public InputAction @Handbrake => m_Wrapper.m_Driving_Handbrake;
        public InputActionMap Get() { return m_Wrapper.m_Driving; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(DrivingActions set) { return set.Get(); }
        public void SetCallbacks(IDrivingActions instance)
        {
            if (m_Wrapper.m_DrivingActionsCallbackInterface != null)
            {
                @Accelerate.started -= m_Wrapper.m_DrivingActionsCallbackInterface.OnAccelerate;
                @Accelerate.performed -= m_Wrapper.m_DrivingActionsCallbackInterface.OnAccelerate;
                @Accelerate.canceled -= m_Wrapper.m_DrivingActionsCallbackInterface.OnAccelerate;
                @Brake.started -= m_Wrapper.m_DrivingActionsCallbackInterface.OnBrake;
                @Brake.performed -= m_Wrapper.m_DrivingActionsCallbackInterface.OnBrake;
                @Brake.canceled -= m_Wrapper.m_DrivingActionsCallbackInterface.OnBrake;
                @Turning.started -= m_Wrapper.m_DrivingActionsCallbackInterface.OnTurning;
                @Turning.performed -= m_Wrapper.m_DrivingActionsCallbackInterface.OnTurning;
                @Turning.canceled -= m_Wrapper.m_DrivingActionsCallbackInterface.OnTurning;
                @Handbrake.started -= m_Wrapper.m_DrivingActionsCallbackInterface.OnHandbrake;
                @Handbrake.performed -= m_Wrapper.m_DrivingActionsCallbackInterface.OnHandbrake;
                @Handbrake.canceled -= m_Wrapper.m_DrivingActionsCallbackInterface.OnHandbrake;
            }
            m_Wrapper.m_DrivingActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Accelerate.started += instance.OnAccelerate;
                @Accelerate.performed += instance.OnAccelerate;
                @Accelerate.canceled += instance.OnAccelerate;
                @Brake.started += instance.OnBrake;
                @Brake.performed += instance.OnBrake;
                @Brake.canceled += instance.OnBrake;
                @Turning.started += instance.OnTurning;
                @Turning.performed += instance.OnTurning;
                @Turning.canceled += instance.OnTurning;
                @Handbrake.started += instance.OnHandbrake;
                @Handbrake.performed += instance.OnHandbrake;
                @Handbrake.canceled += instance.OnHandbrake;
            }
        }
    }
    public DrivingActions @Driving => new DrivingActions(this);

    // BetweenRounds
    private readonly InputActionMap m_BetweenRounds;
    private IBetweenRoundsActions m_BetweenRoundsActionsCallbackInterface;
    private readonly InputAction m_BetweenRounds_SpawnNewCar;
    public struct BetweenRoundsActions
    {
        private @InputActions m_Wrapper;
        public BetweenRoundsActions(@InputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @SpawnNewCar => m_Wrapper.m_BetweenRounds_SpawnNewCar;
        public InputActionMap Get() { return m_Wrapper.m_BetweenRounds; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(BetweenRoundsActions set) { return set.Get(); }
        public void SetCallbacks(IBetweenRoundsActions instance)
        {
            if (m_Wrapper.m_BetweenRoundsActionsCallbackInterface != null)
            {
                @SpawnNewCar.started -= m_Wrapper.m_BetweenRoundsActionsCallbackInterface.OnSpawnNewCar;
                @SpawnNewCar.performed -= m_Wrapper.m_BetweenRoundsActionsCallbackInterface.OnSpawnNewCar;
                @SpawnNewCar.canceled -= m_Wrapper.m_BetweenRoundsActionsCallbackInterface.OnSpawnNewCar;
            }
            m_Wrapper.m_BetweenRoundsActionsCallbackInterface = instance;
            if (instance != null)
            {
                @SpawnNewCar.started += instance.OnSpawnNewCar;
                @SpawnNewCar.performed += instance.OnSpawnNewCar;
                @SpawnNewCar.canceled += instance.OnSpawnNewCar;
            }
        }
    }
    public BetweenRoundsActions @BetweenRounds => new BetweenRoundsActions(this);

    // Menus
    private readonly InputActionMap m_Menus;
    private IMenusActions m_MenusActionsCallbackInterface;
    private readonly InputAction m_Menus_Escape;
    private readonly InputAction m_Menus_Accept;
    private readonly InputAction m_Menus_MousePosition;
    public struct MenusActions
    {
        private @InputActions m_Wrapper;
        public MenusActions(@InputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Escape => m_Wrapper.m_Menus_Escape;
        public InputAction @Accept => m_Wrapper.m_Menus_Accept;
        public InputAction @MousePosition => m_Wrapper.m_Menus_MousePosition;
        public InputActionMap Get() { return m_Wrapper.m_Menus; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MenusActions set) { return set.Get(); }
        public void SetCallbacks(IMenusActions instance)
        {
            if (m_Wrapper.m_MenusActionsCallbackInterface != null)
            {
                @Escape.started -= m_Wrapper.m_MenusActionsCallbackInterface.OnEscape;
                @Escape.performed -= m_Wrapper.m_MenusActionsCallbackInterface.OnEscape;
                @Escape.canceled -= m_Wrapper.m_MenusActionsCallbackInterface.OnEscape;
                @Accept.started -= m_Wrapper.m_MenusActionsCallbackInterface.OnAccept;
                @Accept.performed -= m_Wrapper.m_MenusActionsCallbackInterface.OnAccept;
                @Accept.canceled -= m_Wrapper.m_MenusActionsCallbackInterface.OnAccept;
                @MousePosition.started -= m_Wrapper.m_MenusActionsCallbackInterface.OnMousePosition;
                @MousePosition.performed -= m_Wrapper.m_MenusActionsCallbackInterface.OnMousePosition;
                @MousePosition.canceled -= m_Wrapper.m_MenusActionsCallbackInterface.OnMousePosition;
            }
            m_Wrapper.m_MenusActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Escape.started += instance.OnEscape;
                @Escape.performed += instance.OnEscape;
                @Escape.canceled += instance.OnEscape;
                @Accept.started += instance.OnAccept;
                @Accept.performed += instance.OnAccept;
                @Accept.canceled += instance.OnAccept;
                @MousePosition.started += instance.OnMousePosition;
                @MousePosition.performed += instance.OnMousePosition;
                @MousePosition.canceled += instance.OnMousePosition;
            }
        }
    }
    public MenusActions @Menus => new MenusActions(this);
    private int m_KeyboardMouseSchemeIndex = -1;
    public InputControlScheme KeyboardMouseScheme
    {
        get
        {
            if (m_KeyboardMouseSchemeIndex == -1) m_KeyboardMouseSchemeIndex = asset.FindControlSchemeIndex("Keyboard&Mouse");
            return asset.controlSchemes[m_KeyboardMouseSchemeIndex];
        }
    }
    private int m_GamepadSchemeIndex = -1;
    public InputControlScheme GamepadScheme
    {
        get
        {
            if (m_GamepadSchemeIndex == -1) m_GamepadSchemeIndex = asset.FindControlSchemeIndex("Gamepad");
            return asset.controlSchemes[m_GamepadSchemeIndex];
        }
    }
    public interface IDrivingActions
    {
        void OnAccelerate(InputAction.CallbackContext context);
        void OnBrake(InputAction.CallbackContext context);
        void OnTurning(InputAction.CallbackContext context);
        void OnHandbrake(InputAction.CallbackContext context);
    }
    public interface IBetweenRoundsActions
    {
        void OnSpawnNewCar(InputAction.CallbackContext context);
    }
    public interface IMenusActions
    {
        void OnEscape(InputAction.CallbackContext context);
        void OnAccept(InputAction.CallbackContext context);
        void OnMousePosition(InputAction.CallbackContext context);
    }
}
