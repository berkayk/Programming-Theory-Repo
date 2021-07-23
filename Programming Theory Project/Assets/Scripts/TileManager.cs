using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ExtensionMethods;


public class TileManager : MonoBehaviour
{
    [SerializeField] private Camera mainCamera;
    [SerializeField] private List<GameObject> blocks;

    [SerializeField] int gridWidth = 4;
    [SerializeField] int gridHeight = 4;

    private float gap = 3.0f;

    // Start is called before the first frame update
    void Start()
    {
        PlaceTiles();
        CenterCamera();
    }

    private void CenterCamera()
    {
        if (mainCamera != null)
        {
            // Center pos
            Vector3 bottomRight = new Vector3((gridWidth - 1) * gap, 0, (gridHeight - 1) * gap);
            Vector3 center = bottomRight / 2;
            mainCamera.transform.Translate(center.x, 0, 0);
            mainCamera.transform.LookAt(center);
        }
    }

    private void PlaceTiles()
    {
        if (blocks.Count < 1)
        {
            Debug.LogError("You must define blocks!");
            return;
        }
        
        for (int i = 0; i < gridHeight; i++)
        {
            for (int j = 0; j < gridWidth; j++)
            {
                GameObject block = blocks.PickRandom();
                Vector3 position = new Vector3(i * gap, 0, j * gap);
                Instantiate(block, position, block.transform.rotation);
            }
        }
        
        // Center object
    }

    // Update is called once per frame
    void Update()
    {
    }
}