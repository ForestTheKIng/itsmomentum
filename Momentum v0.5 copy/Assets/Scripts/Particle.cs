using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Particle : MonoBehaviour
{
    public GameObject smoke;
    void OnCollisionEnter (Collision col)
    {
        Debug.Log("instatiate");
        // Instantiate(smoke, new Vector3(0, -1, 0), Quaternion.identity);
    }
}
