using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject obstacle;
    public Vector3 SpawnPos = new Vector3 (25,0,0);
    private float StartPos = 2;
    private float Repeat = 2;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObstacle",StartPos,Repeat);
    }

    // Update is called once per frame
    void SpawnObstacle()
    {
       Instantiate(obstacle , SpawnPos , Quaternion.identity); 
    }
}
