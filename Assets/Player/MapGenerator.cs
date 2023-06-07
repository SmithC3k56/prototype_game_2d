using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapGenerator : MonoBehaviour
{
    public GameObject tilePrefab;
    public int mapSizeX = 10;
    public int mapSizeY = 10;
    public float tileSize = 1f;

    private void Start()
    {
        this.GenerateMap();
    }

    protected virtual void GenerateMap()
    {
        for (int x = 0; x < this.mapSizeX; x++)
        {
            for (int y = 0; y < mapSizeY; y++)
            {
                Vector3 tilePosition = new Vector3(x * this.tileSize, y * this.tileSize, 0);
                Vector3 tilePositionNegative = new Vector3(- x * this.tileSize, -y * this.tileSize, 0);
                Vector3 tilePositionNegativey = new Vector3(x * this.tileSize, -y * this.tileSize, 0);
                Vector3 tilePositionNegativex = new Vector3(-x * this.tileSize, y * this.tileSize, 0);
                Instantiate(tilePrefab, tilePosition, Quaternion.identity); //clone title map
                Instantiate(tilePrefab, tilePositionNegative, Quaternion.identity); //clone title map
                Instantiate(tilePrefab, tilePositionNegativey, Quaternion.identity); //clone title map
                Instantiate(tilePrefab, tilePositionNegativex, Quaternion.identity); //clone title map
            }
        }
    }


}
