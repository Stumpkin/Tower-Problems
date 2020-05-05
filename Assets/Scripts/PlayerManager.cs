using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public int money;
    private int timer;

    // Start is called before the first frame update
    void Start()
    {
        money = 0;
        timer = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (timer == 10)
        {
            money += 2;
            timer = 0;
        }

        else
        {
            timer += (int)(Time.deltaTime + 1);
        }
    }
}
