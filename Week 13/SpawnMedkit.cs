using System.Collections;
using UnityEngine;

public class SpawnMedkit : MonoBehaviour
{
    public GameObject medkit;
    public PlayerHealth playerHealth;
    public int spawnRangeY;
    public int spawnRangeX;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Spawn();
    }

    void Spawn()
    {
        float randomX = Random.Range(-spawnRangeX, spawnRangeX);
        float randomY = Random.Range(-spawnRangeY, spawnRangeY);

        Quaternion spawnRotation = medkit.transform.rotation;
        Vector3 spawnPostion = transform.position + new Vector3(randomX, randomY, 0f);
        Medic newKit = Instantiate(medkit, spawnPostion, spawnRotation).GetComponent<Medic>();
        newKit.playerHealth = playerHealth;
    }
}
