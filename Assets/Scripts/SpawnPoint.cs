using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using UnityEngine;

public class SpawnPoint : MonoBehaviour {
    
    public GameObject Spawn(GameObject prefab) {
        return Instantiate(prefab, transform.position, transform.rotation, null);
    }

}
