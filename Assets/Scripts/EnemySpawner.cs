using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject enemy;
    private GameObject newEnemy;
    private SpriteRenderer rend;
    private int randomSpawnZone;
    private float randomXposition, randomYposition;
    private Vector3 spawnPosition;

 



    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnNewEnemy",0f,6f);

    }

    // Update is called once per frame
    void Update()
    {
       
    }


    private void SpawnNewEnemy(){

        randomSpawnZone = Random.Range(0,4);
        switch (randomSpawnZone){
            case 0: 
                randomXposition = Random.Range(-4f,-4f);
                randomYposition = Random.Range(-3f,-3f);
                break;
            case 1: 
                randomXposition = Random.Range(-4f,4f);
                randomYposition = Random.Range(-2f,-3f);
                break;
            case 2: 
                randomXposition = Random.Range(4f,4f);
                randomYposition = Random.Range(-3f,3f);
                break;
            case 3: 
                randomXposition = Random.Range(-4f,4f);
                randomYposition = Random.Range(2f,3f);
                break;
        }
        spawnPosition = new Vector3(randomXposition,randomYposition,0f);
        newEnemy = Instantiate(enemy,spawnPosition,Quaternion.identity);
      
        rend = newEnemy.GetComponent<SpriteRenderer>();
        rend.color = new Color(Random.Range(0,2),Random.Range(0,2),Random.Range(0,2),1f);
    }

   
}
