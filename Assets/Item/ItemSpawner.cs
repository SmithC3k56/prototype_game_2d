using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemSpawner : MonoBehaviour
{
    public List<GameObject> itemPrefabs;
    public int numberOfItems = 10;
    public float spawnRadius = 10f;

    private void Start()
    {
        SpawnItems();
    }

    private void SpawnItems()
    {
        for (int i = 0; i < numberOfItems; i++)
        {
            float randomX = Random.Range(-spawnRadius, spawnRadius);
            float randomY = Random.Range(-spawnRadius, spawnRadius);
            int itemLevel= Random.Range(0, this.itemPrefabs.Count);
            Vector3 spawnPosition = new Vector3(randomX, randomY, 0f);

            Instantiate(itemPrefabs[itemLevel], spawnPosition, Quaternion.identity);
        }
    }


}
