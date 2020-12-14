using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapGenerator : MonoBehaviour
{
    public GameObject tilePrefab;
    public GameObject tilePrefab2;
    public GameObject tilePrefab3;
    public GameObject tilePrefab4;

    int mapWidth = 10;
    int mapHeight = 0;

    public float tileOffset = 17.05f;

    // Start is called before the first frame update
    void Start()
    {
        CreateQuadTileMap();
    }

    void CreateQuadTileMap()
    {
        for (int x = 0; x <= mapWidth; x++)
        {
            for (int z = 0; z <= mapHeight; z++)
            {
                GameObject TempGO = Instantiate(tilePrefab);
                TempGO.transform.position = new Vector3(x * tileOffset, 0, z * tileOffset);

            }
        }
    }
    void SetTileInfo(GameObject GO, int x, int z)
    {
        GO.transform.parent.parent = transform;
        GO.name = x.ToString() + ", " + z.ToString();
    }
}
