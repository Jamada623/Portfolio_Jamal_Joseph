using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAi : MonoBehaviour
{
    public Vector3 enemyPos;
    public Transform expObj;
   

    public float xDiff;
    public float yDiff;

    public float xEnemyVel;
    public float yEnemyVel;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        enemyPos = transform.position;
        xDiff = PlayerControls.heroPos.x - enemyPos.x;
        yDiff = PlayerControls.heroPos.y - enemyPos.y;

        if (xDiff > 0)
        {
            xEnemyVel = 1.5f;
        }
        if (xDiff < 0)
        {
            xEnemyVel = -1.5f;
        }
        if (yDiff > 0)
        {
            yEnemyVel = 1.5f;
        }
        if (yDiff < 0)
        {
            yEnemyVel = -1.5f;
        }

        GetComponent<Rigidbody>().velocity = new Vector3(xEnemyVel, yEnemyVel, 0);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.name == "playerBullet(Clone)")
        {
            Destroy(gameObject);
            Transform explosion = Instantiate(expObj, transform.position, expObj.rotation) as Transform;
            Destroy(explosion.gameObject, 2f);
            
        }

        if (other.name == "rifle(Clone)")
        {
            Destroy(gameObject);
            Transform explosion = Instantiate(expObj, transform.position, expObj.rotation) as Transform;
            Destroy(explosion.gameObject, 2f);

        }

        if (other.name == "Shotgun bullet(Clone)")
        {
            Destroy(gameObject);
            Transform explosion = Instantiate(expObj, transform.position, expObj.rotation) as Transform;
            Destroy(explosion.gameObject, 2f);

        }

    }
}
