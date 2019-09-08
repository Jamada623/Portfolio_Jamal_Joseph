using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HurtPlayer : MonoBehaviour
{
    public int dmgdealt;

    public void OnTriggerEnter(Collider other)
    {
        if(other.name == "Player")
        {
            other.gameObject.GetComponent<PlayerHealthManager>().HurtPlayer(dmgdealt);
        }
    }
}
