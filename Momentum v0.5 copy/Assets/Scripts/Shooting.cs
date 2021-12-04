using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{

    public WeaponManager weapon;

    public Camera fpsCam;

    public float range = 100f;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (weapon.activeGun == 1)
            {
                PistolShoot();
            }

            if (weapon.activeGun == 3)
            {
                ShotgunShoot();
            }
        }

    }

    void ShotgunShoot() 
    {
        RaycastHit hit;
        if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range)) 
        {

        }
    }

    void PistolShoot () 
    {
        RaycastHit hit;
        if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range)) 
        {
            
        }
    }
}
