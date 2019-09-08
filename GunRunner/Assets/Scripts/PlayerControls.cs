using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour
{
    // creating an array of bullets for the weapon switching
    public GameObject[] Guns;    
    public int currentWeapon = 0;
    private int nrWeapons;

    //controls movement
    public float xValAdj;
    public float yValAdj;

    //controls shooting
    public float xFire;
    public float yFire;

    public static Vector3 heroPos;

    //bullet and shooting variables
    public Transform bulletShot;
    public Transform shotGun;
    public Transform rifle;
    public float shotDelay;

    // Start is called before the first frame update
    void Start()
    {
        nrWeapons = Guns.Length;
        SwitchWeapon(currentWeapon); // Set default gun
    }

    // Update is called once per frame
    void Update()
    {
        heroPos = transform.position;

        xValAdj = Input.GetAxis("xMove");
        yValAdj = Input.GetAxis("yMove");

        xFire = Input.GetAxis("xShoot");
        yFire = Input.GetAxis("yShoot");

        GetComponent<Rigidbody2D>().velocity = new Vector3 (3 * xValAdj, 3 * yValAdj, 0);

        if (currentWeapon == 0)
        {
            //basic weapon
            if (((xFire > .2 || xFire < -.2)) && (shotDelay == 0))
            {
                shotDelay = 1.5f;
                Instantiate(bulletShot, transform.position, bulletShot.rotation);
                StartCoroutine(delayReset());
            }

            if (((yFire > .2 || yFire < -.2)) && (shotDelay == 0))
            {
                shotDelay = 1.5f;
                Instantiate(bulletShot, transform.position, bulletShot.rotation);
                StartCoroutine(delayReset());
            }
        }

        if (currentWeapon == 1)
        {
            //shotgun
            if (((xFire > .2 || xFire < -.2)) && (shotDelay == 0))
            {
                shotDelay = 0.9f;
                Instantiate(shotGun, transform.position, shotGun.rotation);
                
                StartCoroutine(delayReset2());
            }

            if (((yFire > .2 || yFire < -.2)) && (shotDelay == 0))
            {
                shotDelay = 0.9f;
                Instantiate(shotGun, transform.position, shotGun.rotation);
                
                StartCoroutine(delayReset2());
            }
        }

        if (currentWeapon == 2)
        {
            //rifle
            if (((xFire > .2 || xFire < -.2)) && (shotDelay == 0))
            {
                shotDelay = 0.2f;
                Instantiate(rifle, transform.position, rifle.rotation);
                StartCoroutine(delayReset1());
            }

            if (((yFire > .2 || yFire < -.2)) && (shotDelay == 0))
            {
                shotDelay = 0.2f;
                Instantiate(rifle, transform.position, rifle.rotation);
                StartCoroutine(delayReset1());
            }
        }

        if (Input.GetButtonDown("Left_Bumper") && currentWeapon > 0)
        {
            currentWeapon --;
            SwitchWeapon(currentWeapon);
        }
            
        if (Input.GetButtonDown("Right_Bumper") && currentWeapon < 2)
        {
            currentWeapon ++;
            SwitchWeapon(currentWeapon);
        }
    }


    //switch weapon based on current array position
    
    void SwitchWeapon(int index)
    {

        for (int i = 0; i < nrWeapons; i++)
        {
            if (i == index)
            {
                Guns[i].gameObject.SetActive(true);
            }
            else
            {
                Guns[i].gameObject.SetActive(false);
            }
        }
    }
    

    //setting different reset timings for the different weapons
    IEnumerator delayReset()
    {

        yield return new WaitForSeconds(0.3f);
        shotDelay = 0;
    }

    IEnumerator delayReset1()
    {

        yield return new WaitForSeconds(0.1f);
        shotDelay = 0;
    }
    IEnumerator delayReset2()
    {

        yield return new WaitForSeconds(0.6f);
        shotDelay = 0;
    }

}
