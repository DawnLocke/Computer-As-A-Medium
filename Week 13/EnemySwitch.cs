using UnityEngine;

public class EnemySwitch : MonoBehaviour
{
    public SpawnEnemy spawnEnemy;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        spawnEnemy.isSpawning = false;
    }
}
