using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttacArea : MonoBehaviour
{
    private int damage = 5;

    private void OnTriggerEnter(Collider collider)
    {
        Debug.Log("Collider hit");
        if(collider.GetComponent<Health>() != null)
        {
            Health health = collider.GetComponent<Health>();
            health.TakeDamage(damage);
            Debug.Log("Hit");
        }
        else
        {
            Debug.Log("No Hit");
        }
    }
}
