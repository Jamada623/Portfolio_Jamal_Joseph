using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlimHealthManager : MonoBehaviour
{
    public int startingHP;
    public int currentHP;
    // Start is called before the first frame update
    void Start()
    {
        currentHP = 3;
    }

    // Update is called once per frame
    void Update()
    {
        if (currentHP <= 0)
        {
            Destroy(gameObject);
        }
    }

    public void HurtSlime(int dmgamt)
    {
        currentHP -= dmgamt;
    }
}
