using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tower : MonoBehaviour
{
    public int HP;
    private int remainingHP;
    public int Coins;
    float timer;
    void Start()
    {
        remainingHP = HP;
        timer = 0;
        Coins = 0;
    }

    void Update()
    {
        if (timer >= 15)
        {
            Coins += 3;
            timer = 0;
        }

        else
        {
            timer += 1 * Time.deltaTime;
        }

        if (remainingHP <= 0)
        {
            Destroy(gameObject);
        }
        Debug.Log(getHP());
    }

    public void takeDamage(int ouch)
    {
        remainingHP -= ouch;
        Debug.Log(string.Format("HP: {0}", remainingHP));
    }

    public int getHP()
    {
        return remainingHP;
    }
}

