using UnityEngine;

public class Enemy_Respawner : MonoBehaviour
{
    [SerializeField] private GameObject enemyPrefab;
    [SerializeField] private Transform[] respawnPoints;
    [SerializeField] private float cooldown;
    [Space]
    [SerializeField] private float coolDownDecreaseRate = .05f;
    [SerializeField] private float coolDownCap = .7f;
    private float timer;

    private Transform player;

    private void Awake()
    {
        player = FindAnyObjectByType<Player>().transform;
    }

    private void Update()
    {
        timer -= Time.deltaTime;
        

        if(timer < 0)
        {
            timer = cooldown;
            CreateNewEnemy();

            cooldown = Mathf.Max(coolDownCap, cooldown - coolDownDecreaseRate);
        }
    }

    private void CreateNewEnemy()
    {
        int respawnPointIndex = Random.Range(0, respawnPoints.Length);
        Vector3 spawnPoint = respawnPoints[respawnPointIndex].position;

        GameObject newEnemy = Instantiate(enemyPrefab, spawnPoint, Quaternion.identity);

        bool createsOnTheRight = newEnemy.transform.position.x > player.transform.position.x;

        if (createsOnTheRight)
        {
            newEnemy.GetComponent<Enemy>().Flip();
        }
    }


}
