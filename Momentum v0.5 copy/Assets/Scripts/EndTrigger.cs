using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndTrigger : MonoBehaviour
{
    public Transform player;

    public Timer timer;
    public int Level = 1;
    
    public Vector3 spawnCoords = new Vector3(-74, 12, -326);

    public GameObject playScreen;



    void Start() 
    {
        
    }
    void OnTriggerEnter () 
    {

        Debug.Log("loading scene");
        SceneManager.LoadScene(0);
    
    }
}


