using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HurtEnemy : MonoBehaviour
{
    private int dmgdealt;

    public void OnTriggerEnter(Collider other)
    {
        dmgdealt = 1;
        if (other.name == "slime(Clone)")
        {
            other.gameObject.GetComponent<SlimHealthManager>().HurtSlime(dmgdealt);
        }
    }
}
