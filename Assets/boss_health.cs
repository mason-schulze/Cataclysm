using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class health_boss : MonoBehaviour
{
    float start_health = 200;
    float current_health;
    bool dead;
    bool damaged;
    // Start is called before the first frame update
    void Start()
    {
        current_health = start_health;
        dead = false;
        damaged = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (damaged)
        {
            // Damage animation
        }
        else
        {
            // Change color back to normal
        }
        damaged = false;
    }

    public void ouch(float dmg)
    {
        damaged = true;
        current_health -= dmg;
        if (current_health <= 0)
        {
            death();
        }
    }

    void death()
    {
        dead = true;
    }
}
