using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponManager : MonoBehaviour
{
    public GameObject Rpg;

    public GameObject grapple;

    public GameObject shotgun;

    public int activeGun;
    
    // Gun Switching

    void Update() 
    {
        if(Input.GetKeyDown("1"))
        {
            activeGun = 1;
            grapple.SetActive(true);
            Rpg.SetActive(false);
            shotgun.SetActive(false);
        } else if (Input.GetKeyDown("2")) 
        {
            activeGun = 2;
            grapple.SetActive(false);
            Rpg.SetActive(true);  
            shotgun.SetActive(false); 
        } else if (Input.GetKeyDown("3")) 
        {
            activeGun = 3;
            grapple.SetActive(false);
            Rpg.SetActive(false);
            shotgun.SetActive(true);   
        }
    }


    
}
