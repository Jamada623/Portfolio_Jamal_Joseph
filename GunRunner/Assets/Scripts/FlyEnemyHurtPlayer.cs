using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyEnemyHurtPlayer : MonoBehaviour
{
    private int dmgdealt;

    public void OnTriggerEnter(Collider other)
    {
        dmgdealt = 1;
        if (other.name == "Player")
        {
            other.gameObject.GetComponent<PlayerHealthManager>().HurtPlayer(dmgdealt);
        }
    }
}
