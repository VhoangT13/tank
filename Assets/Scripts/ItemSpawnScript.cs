using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemSpawnScript : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private GameObject item;
    private GameObject newItem;
    private SpriteRenderer rend;
    private int randomSpawnZone;
    private float randomXposition, randomYposition;
    private Vector3 spawnPosition;
    void Start()
    {
          InvokeRepeating("SpawnNewItem",0f,25f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void SpawnNewItem(){
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
        newItem = Instantiate(item,spawnPosition,Quaternion.identity);

        rend = newItem.GetComponent<SpriteRenderer>();
    }
}
