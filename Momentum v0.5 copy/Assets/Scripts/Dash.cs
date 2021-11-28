using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Dash : MonoBehaviour
{
    Rigidbody rig;
    public float dashspeed;
    bool isDashing;

    public GameObject dashEffect;


    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftShift)) 
            isDashing = true;
            
    }

    private void FixedUpdate() {
        if (isDashing)
            Dashing();    
    }

    private void Dashing()
    {
        rig.AddForce(transform.forward * dashspeed, ForceMode.Impulse);
        isDashing = false;

        GameObject effect = Instantiate(dashEffect, Camera.main.transform.position,dashEffect.transform.rotation);
        effect.transform.parent = Camera.main.transform;
        effect.transform.LookAt(transform);
    }
}
