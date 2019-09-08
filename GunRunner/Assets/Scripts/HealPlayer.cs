using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealPlayer : MonoBehaviour
{
    public int dmghealed;

    public void OnTriggerEnter2D(Collider2D other)
    {
        
        if (other.name == "Player")
        {
            other.gameObject.GetComponent<PlayerHealthManager>().HealPlayer(dmghealed);
            Destroy(gameObject);
        }
    }
}
