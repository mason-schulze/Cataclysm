using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projectile : MonoBehaviour
{
    const float speed = 7;
    const float DMG = 1;
    bool player_hit = false;
    GameObject player_char = GameObject.Find("Player");
    player_health player_health;

    // Start is called before the first frame update
    void Start()
    {
        player_health = player_char.GetComponent<player_health>();
        transform.position = Vector3.MoveTowards(transform.position, player_char.transform.position, speed);
    }

    // Update is called once per frame
    void Update()
    {
        // If hits player, damage
        // Need mechanic to see if hits player
        if (player_hit)
        {
            player_health.ouch(DMG);
        }
    }
}
