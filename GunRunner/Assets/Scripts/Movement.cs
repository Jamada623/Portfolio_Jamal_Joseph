using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public GameObject playerBullet;
    public GameObject Firepoint;

    public float speed = 0.1f;
    Transform Player;

    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.Find("Player").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 movement = Vector3.zero;

        if (Input.GetButtonDown("Fire1"))
        {
            GameObject bullet1 = (GameObject)Instantiate(playerBullet);
            bullet1.transform.position = Firepoint.transform.position;
            
        }

               
        if (Input.GetKey(KeyCode.W))
        {
            movement=(Vector3.up*speed);
        }
        if (Input.GetKey(KeyCode.S))
        {
            movement = (-Vector3.up * speed);
        }
        if (Input.GetKey(KeyCode.D))
        {
            movement = (Vector3.right * speed);
        }
        if (Input.GetKey(KeyCode.A))
        {
            movement = (-Vector3.right * speed);
        }

        Player.Translate(movement);
    }

    
}
