using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class World : MonoBehaviour
{
    public GameObject GrasPrefab;
    public GameObject ZandPrefab;

    public int WorldX = 100;
    public int WorldZ = 100;
    
    // Start is called before the first frame update
    void Start()
    {
        for (int x = 0; x < WorldX; x++)
        {
            for (int z = 0; z < WorldZ; z++)
            {
                //GameObject.Instantiate maakt een nieuw object aan
                GameObject newBlock = GameObject.Instantiate(ZandPrefab, new Vector3(x - WorldX/2, 0, z - WorldZ/2), Quaternion.identity);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
