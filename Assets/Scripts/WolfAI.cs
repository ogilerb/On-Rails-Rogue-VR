using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class WolfAI : MonoBehaviour
{
    NavMeshAgent enemy;
    GameObject player;
    float distToPlayer;
    bool playerNoticed = false;
    bool isAttacking = false;

    public Animator anim;
    public float detectionRange;
    public float attackRange;
    // Start is called before the first frame update
    void Start()
    {
        enemy = GetComponent<NavMeshAgent>();
        player = FindObjectOfType<Player>().gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        distToPlayer = Vector3.Distance(enemy.transform.position, player.transform.position);
        if(distToPlayer < detectionRange)
        {
            enemy.isStopped = false;
            enemy.SetDestination(player.transform.position);

            if (!playerNoticed)
            {
                playerNoticed = true;
                anim.SetBool("isPlayerNoticed", true);
            }
        }
        else
        {
            enemy.isStopped = true;

            if (playerNoticed)
            {
                playerNoticed = false;
                anim.SetBool("isPlayerNoticed", false);
            }
        }
    }
}
