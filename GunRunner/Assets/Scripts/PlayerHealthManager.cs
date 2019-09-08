using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealthManager : MonoBehaviour
{

    public int startingHP;
    public int currentHP;
    // Start is called before the first frame update
    void Start()
    {
        currentHP = startingHP;
    }

    // Update is called once per frame
    void Update()
    {
        if(currentHP <= 0)
        {
            gameObject.SetActive(false);
            FindObjectOfType<AudioController>().Play("PlayerDeath");

        }
    }

    public void HealPlayer(int healamt)
    {
        if (currentHP < startingHP)
        {
            currentHP += healamt;
        }
        else
        {
            currentHP += 0;
        }
    }

    public void HurtPlayer(int dmgamt)
    {
        currentHP -= dmgamt;
    }
}
