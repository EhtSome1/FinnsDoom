using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyAI : MonoBehaviour
{

    public NavMeshAgent agent;

    public Transform player;

    public LayerMask Ground, Player;


    public Vector3 walkPoint;
    bool walkPointset;
    public float walkPointRange;



    public float sightRange, attackRange;
    public bool playerInSightRange, playerInAttackRange;

    public void Awake()
    {
        player = GameObject.Find("Player").transform;
        agent = GetComponent<NavMeshAgent>();
    }
    private void Update()
    {
        playerInSightRange = Physics.CheckSphere(transform.position, sightRange, Player);
        playerInAttackRange = Physics.CheckSphere(transform.position, attackRange, Player);

        if (!playerInSightRange && !playerInAttackRange) Patroling();
        if (playerInSightRange && !playerInAttackRange) ChasePlayer();
        //if (playerInAttackRange && playerInAttackRange) AttackPlayer();

    }

    private void Patroling()
    {
        if (!walkPointset) SearchWalkPoint();

        if (walkPointset)
            agent.SetDestination(walkPoint);

        Vector3 distanceToWalkPoint = transform.position - walkPoint;
        if (distanceToWalkPoint.magnitude < 1f)
            walkPointset = false;
    }
    private void ChasePlayer()
    {
        Debug.Log("löyty");
        agent.SetDestination(player.position);
    }

    private void SearchWalkPoint()
    {
        float randomZ = Random.Range(-walkPointRange, walkPointRange);
        float randomX = Random.Range(-walkPointRange, walkPointRange);

        walkPoint = new Vector3(transform.position.x + randomX, transform.position.y, transform.position.z + randomZ);

        if (Physics.Raycast(walkPoint, -transform.up, 2f, Ground))
            walkPointset = true;

    }
    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, attackRange);
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, sightRange);



    }

    //private void AttackPlayer()
    //{
    //    agent.SetDestination(transform.position);
    //    transform.LookAt(player);    

    //    if (!alreadyAttacked)
    //    {
            
    //     Rigidbody rb = Instantiate(projectile, transform.position, Quaternion.identity).GetComponent<Rigidbody>();
    //        rb.AddForce(transform.forward* 32f, ForceMode.Impulse);
    //        rb.AddForce(transform.up* 8f, ForceMode.Impulse);
    //        alreadyAttacked = true;
    //        Invoke(nameof(ResetAttack), timeBetweenAttacks);
    //    }


    }
    //private void ResetAttack()
    //{
    //alreadyAttacked = false;
    //}

//public void TakeDamage(int damage)
//{
//    hyttyHealth -= damage;

//    if (hyttyHealth <= 0)
//    {
//        DestroyEnemy();
//    }
//}

//private void DestroyEnemy()
//{
//    Destroy(gameObject);
//}


