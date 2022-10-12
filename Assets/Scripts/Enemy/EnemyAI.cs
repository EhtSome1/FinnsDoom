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
        //onko pelaaja näkyvissä?
        playerInSightRange = Physics.CheckSphere(transform.position, sightRange, Player);
        //jos pelaaja ei ole näkyvissä// Patrol()
        if (!playerInSightRange && !playerInAttackRange) Patroling();
        //onko pelaaja lähellä?
        playerInAttackRange = Physics.CheckSphere(transform.position, attackRange, Player);
        //jos pelaaja on näkyvissä // ChasePlayer()
        if (playerInSightRange && !playerInAttackRange) ChasePlayer();
    }
    //Satunnainen pelaajan etsiminen
    private void SearchWalkPoint()
    {
        float randomZ = Random.Range(-walkPointRange, walkPointRange);
        float randomX = Random.Range(-walkPointRange, walkPointRange);
        //Satunnaisen muuttujan(saapumispisteen) luonti = (walkPoint)
        walkPoint = new Vector3(transform.position.x + randomX, transform.position.y, transform.position.z + randomZ);
        if (Physics.Raycast(walkPoint, -transform.up, 2f, Ground))
            walkPointset = true;
    }
    //Pelaajan etsiminen
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
    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, attackRange);
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, sightRange);
    }
   }


