using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttak : MonoBehaviour
{
    public GameObject Player;
    public float moveSpeed = 5f;
    private Rigidbody rb;
    private Vector3 movement;
    public Transform objectToLookAt;

    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
        Player = FindObjectOfType<Player>().gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        if (Player == null)
        {
            return;
        }
        Vector3 direction = Player.transform.position - transform.position;
        transform.LookAt(Player.transform);
        direction.Normalize(); 
        movement = direction; 
    }
    private void FixedUpdate()
    {
        moveCharacter(movement);
    }
    void moveCharacter(Vector3 direction)
    {
        rb.MovePosition((Vector3)transform.position + (direction * moveSpeed * Time.deltaTime));
    }
}