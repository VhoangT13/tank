using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedUpScript : MonoBehaviour
{
    // Start is called before the first frame update
    public TankMover tankMover;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SpeedUp(){
        tankMover.speed+=1;
    }
}
