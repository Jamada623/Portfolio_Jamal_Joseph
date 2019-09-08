using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlimeEnemyAi : MonoBehaviour
{
    public Vector3 enemyPos;
    public Transform expObj;

    public int startingHP;
    public int currentHP;

    public float xDiff;
    public float yDiff;

    public float xEnemyVel;
    public float yEnemyVel;

    // Start is called before the first frame update
    void Start()
    {
        currentHP = 3;
    }

    // Update is called once per frame
    void Update()
    {
        enemyPos = transform.position;
        xDiff = PlayerControls.heroPos.x - enemyPos.x;
        yDiff = PlayerControls.heroPos.y - enemyPos.y;

        if (xDiff > 0)
        {
            xEnemyVel = 1f;
        }
        if (xDiff < 0)
        {
            xEnemyVel = -1f;
        }
        if (yDiff > 0)
        {
            yEnemyVel = 1f;
        }
        if (yDiff < 0)
        {
            yEnemyVel = -1f;
        }

        GetComponent<Rigidbody>().velocity = new Vector3(xEnemyVel, yEnemyVel, 0);

        if (currentHP <= 0)
        {
            Destroy(gameObject);
            Transform explosion = Instantiate(expObj, transform.position, expObj.rotation) as Transform;
            Destroy(explosion.gameObject, 2f);
        }
    }

    public void HurtSlime(int dmgamt)
    {
        currentHP -= dmgamt;
    }

    /*
    void OnTriggerEnter(Collider other)
    {
        if (other.name == "playerBullet(Clone)")
        {

            //Destroy(gameObject);
            //Transform explosion = Instantiate(expObj, transform.position, expObj.rotation) as Transform;
            //Destroy(explosion.gameObject, 2f);

        }

        
    }*/
}

