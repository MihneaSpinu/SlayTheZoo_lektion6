using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] private int health = 100;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
          //  TakeDamage(10);
        }

        if (Input.GetKeyDown(KeyCode.H))
        {
          //  Heal(10);
        }
    }

    public void TakeDamage(int damage)
    {
        health -= damage;
        if (health <= 0)
        {
            Die();
        }
    }

    public void Die()
    {
        Debug.Log("I died");
        Destroy(gameObject);
    }

    public int GetHealth()
    {
        return health;
    }

    public void SetHealth(int newHealth)
    {
        health = newHealth;
    }

    public void Heal(int healAmount)
    {
        health += healAmount;
    }

    public void HealToFull()
    {
        health = 100;
    }

}
