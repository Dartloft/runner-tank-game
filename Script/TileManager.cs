using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileManager : MonoBehaviour
{
    //Declaro la clase y el objeto
    GroundSpawn groundSpawner;

    public GameObject obstacle;

    void Start()
    {
        groundSpawner = GameObject.FindObjectOfType<GroundSpawn>();
        SpawnObstacle();
        SpawnCoin();   
    }

    private void OnTriggerExit(Collider other)
    {
        groundSpawner.SpawnTile();
        Destroy(gameObject, 2);
    }

    // Update is called once per frame
    private void Update()
    {
      
    }

    void SpawnObstacle()//Metodo para la creacion de los muros
    {
        //Creo la variable y le digo aleatoriamente la posicion donde va a aparecer
        int obstacleSpawnIndex = Random.Range(2, 5);
        //Determina el punto donde va a empezar los objetos
        Transform spawnPoint = transform.GetChild(obstacleSpawnIndex).transform;
        //Instancia los objetos
        Instantiate(obstacle, spawnPoint.position, Quaternion.identity, transform);
    }

    //objeto moneda
    public GameObject coin;

    void SpawnCoin()//Metodo para el spawneo de la monedas 
    {   //variable spawn coin
        int coinSpawn = 3;
        for(int i = 0; i < coinSpawn; i++)
        {
            //variable de objeto temporal que instancia la moneda
          GameObject temp = Instantiate(coin,transform);
          temp.transform.position = GetRandomPointInCollider(GetComponent<Collider>());
        }
    }
    
    Vector3 GetRandomPointInCollider(Collider collider)
    {
        Vector3 point = new Vector3(
            Random.Range(collider.bounds.min.x, collider.bounds.max.x),
            Random.Range(collider.bounds.min.y, collider.bounds.max.y),
            Random.Range(collider.bounds.min.z, collider.bounds.max.z)
            );

        if(point != collider.ClosestPoint(point))
        {
            point = GetRandomPointInCollider(collider);
        }

        point.y = 1;
        return point;
    }
}
