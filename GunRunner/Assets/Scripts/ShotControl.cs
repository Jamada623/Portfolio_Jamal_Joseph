using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotControl : MonoBehaviour
{
    public float xFire;
    public float yFire;
    public float shotR;// rotate bullets
    public int dmgdealt;
    // Start is called before the first frame update
    void Start()
    {
        xFire = Input.GetAxis("xShoot");
        yFire = Input.GetAxis("yShoot");        

        //increases bullet speed to move faster than player
        if (xFire > .2)
        {
            xFire = 5;
            shotR = 90;
        }

        if (xFire < -.2)
        {
            xFire = -5;
            shotR = -90;
        }

        if (yFire > .2)
        {
            yFire = 5;
            shotR = 180;
        }

        if (yFire < -.2)
        {
            yFire = -5;
            shotR = 0;
        }

        GetComponent<Rigidbody>().velocity = new Vector3(xFire,yFire,0);
        GetComponent<Transform>().eulerAngles = new Vector3(0,0,shotR);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.name == "Alien(Clone)")
        {
            Destroy(gameObject);
        }

        if (other.name == "slime(Clone)")
        {
            other.gameObject.GetComponent<SlimeEnemyAi>().HurtSlime(dmgdealt);
            Destroy(gameObject);
        }

        if (other.name == "Fly(Clone)")
        {
            other.gameObject.GetComponent<FlyEnemyAi>().HurtFly(dmgdealt);
            Destroy(gameObject);
        }
    }
        

    void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
