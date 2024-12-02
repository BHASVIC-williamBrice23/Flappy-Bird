using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudSpawner : MonoBehaviour
{
    public GameObject Cloud;
    public float spawnRate=2;
    public float CloudOffset;
    private float timer=0;
    // Start is called before the first frame update
    void Start()
    {
        newCloud();
    }

    // Update is called once per frame
    void Update()
    {
        if(timer < spawnRate){
            timer+=Time.deltaTime;
        }
        else{
            newCloud();
            timer=0;
        }
    }
    void newCloud(){
        CloudOffset=3;
        float LowestPoint=transform.position.y-CloudOffset;
        float HighestPoint=transform.position.y+CloudOffset;
        Instantiate(Cloud, new Vector3(transform.position.x, Random.Range(LowestPoint,HighestPoint),1), transform.rotation);
    }
}
