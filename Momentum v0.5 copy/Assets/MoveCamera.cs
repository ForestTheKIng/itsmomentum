using UnityEngine;

public class MoveCamera : MonoBehaviour {

    public Transform player;

    void Update() {
        transform.position = player.transform.position;

        if (Input.GetKeyDown("w"))
        {
            Debug.Log("ree");
        }

        if (Input.GetKeyUp("w"))
        {
            Debug.Log("reesir");
        }
    }
}