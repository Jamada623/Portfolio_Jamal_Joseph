using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyEnemyAi : MonoBehaviour
{
    public Vector3 enemyPos;
    public Transform expObj;
    public Transform hpdrop;

    public int startingHP;
    public int currentHP;

    public float xDiff;
    public float yDiff;

    public float xEnemyVel;
    public float yEnemyVel;

    // Start is called before the first frame update
    void Start()
    {
        currentHP = 2;
    }

    // Update is called once per frame
    void Update()
    {
        enemyPos = transform.position;
        xDiff = PlayerControls.heroPos.x - enemyPos.x;
        yDiff = PlayerControls.heroPos.y - enemyPos.y;

        if (xDiff > 0)
        {
            xEnemyVel = 2f;
        }
        if (xDiff < 0)
        {
            xEnemyVel = -2f;
        }
        if (yDiff > 0)
        {
            yEnemyVel = 2f;
        }
        if (yDiff < 0)
        {
            yEnemyVel = -2f;
        }

        GetComponent<Rigidbody>().velocity = new Vector3(xEnemyVel, yEnemyVel, 0);

        if (currentHP <= 0)
        {
            Destroy(gameObject);
            Transform explosion = Instantiate(expObj, transform.position, expObj.rotation) as Transform;
            Transform hp = Instantiate(hpdrop, transform.position, hpdrop.rotation) as Transform;
            Destroy(explosion.gameObject, 2f);
            Destroy(hp.gameObject, 10f);
        }
    }

    public void HurtFly(int dmgamt)
    {
        currentHP -= dmgamt;
    }

    /*void OnTriggerEnter(Collider other)
    {
        
        if (other.name == "playerBullet(Clone)")
        {
            Destroy(gameObject);
            Transform explosion = Instantiate(expObj, transform.position, expObj.rotation) as Transform;
            Transform hp = Instantiate(hpdrop, transform.position, hpdrop.rotation) as Transform;

            if (other.name == "Player")
            {
                Destroy(hp.gameObject);

            }

            Destroy(explosion.gameObject, 2f);
            Destroy(hp.gameObject, 10f);
        }

        

    }*/
}