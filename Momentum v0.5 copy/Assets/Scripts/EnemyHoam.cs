using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHoam : MonoBehaviour
{
    public PlayerMovement movement;
    public Transform player;

    public Rigidbody rb;
    void OnTriggerStay (Collider other) 
    {
        if (Input.GetKeyDown("f"))
        {
            Debug.Log("key is f");

            if (other.tag == "Chainable")
            {
                Debug.Log("it is chainable");
                player.position = other.transform.position;
                Destroy(other.gameObject);
            }

        }
    }
}
