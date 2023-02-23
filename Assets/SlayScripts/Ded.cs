using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ded : MonoBehaviour
{
private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("obstacle"))
        {
            Destroy(gameObject);
        }
    }
}
