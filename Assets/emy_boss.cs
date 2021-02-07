using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class emy_boss : MonoBehaviour
{
    CharacterController cc;
    //move speed modifier
    float speed = 10f;
    //gravity
    float gravity = -15f;
    float ySpeed = 0;

    const float RANGE_AGGRO = 15;
    const float RANGE_MELEE = 2;
    const float RANGE_ATK = 15;
    const float DMG = 1;

    GameObject player_char = GameObject.Find("Player");
    public GameObject projectile;
    player_health player_health;
    // In Unity, make player object the goal (drag 'n drop)
    public Transform goal;

    // Start is called before the first frame update
    void Start()
    {
        player_health = player_char.GetComponent<player_health>();
    }

    // Update is called once per frame
    void Update()
    {
        float player_dist = Mathf.Abs(find_dist(transform.position.x, transform.position.z, player_char.transform.position.x, player_char.transform.position.z));
        // Check if player in range for aggro
        if (player_dist <= RANGE_AGGRO)
        {
            NavMeshAgent agent = GetComponent<NavMeshAgent>();
            agent.destination = goal.position;
        }

        // Check if player in range for melee
        if (player_dist <= RANGE_MELEE)
        {
            // Call script to attack animation
            // Tell player_char that it's been damaged & by how much
            player_health.ouch(DMG);
        }

        // Check if player in range for ranged atk
        if (player_dist <= RANGE_ATK)
        {
            // Call script to attack animation
            // Instantiate then fire projectile
            // Make sure prefab is correctly named and has projectile.cs as a component ***********************************
            GameObject projectile_clone = Instantiate(projectile);
        }


    }

    float find_dist(float x1, float y1, float x2, float y2)
    {
        float result = 0;
        result = Mathf.Sqrt(Mathf.Pow(x2 - x1, 2) + Mathf.Pow(y2 - y1, 2));
        return result;
    }
}
