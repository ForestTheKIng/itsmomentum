using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHoam : MonoBehaviour
{
    public PlayerMovement movement;
    public Transform player;

    public Material Mat;

    public Rigidbody rb;
    void OnTriggerStay (Collider other) 
    {
        if (other.tag == "Chainable")
        {
            other.GetComponent<MeshRenderer> ().material = Mat;

            Debug.Log("it is chainable");
            if (Input.GetKeyDown("f"))
            {
                Debug.Log("key is f");
                player.position = other.transform.position;

                Destroy(other.gameObject);


            }
                

        }

        

    }
}
