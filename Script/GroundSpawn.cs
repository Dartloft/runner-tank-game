using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundSpawn : MonoBehaviour
{

    public GameObject groundTile;
    Vector3 nextSpwanPoint;

   public void SpawnTile()
    {
        GameObject temp = Instantiate(groundTile, nextSpwanPoint, Quaternion.identity);
        nextSpwanPoint = temp.transform.GetChild(1).transform.position;
    }
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 15; i++)
        {
            SpawnTile();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
