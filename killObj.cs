using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class killObj : MonoBehaviour {

    private void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag("Player"))
        {
            Destroy(other.transform.parent.gameObject);
            GM.spawn = true;
        }
    }
}
