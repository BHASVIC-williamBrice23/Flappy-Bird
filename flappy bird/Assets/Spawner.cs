using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject Pipe;
    public float spawnRate=2;
    public float PipeOffset;
    private float timer=0;
    // Start is called before the first frame update
    void Start()
    {
        newPipe();
    }

    // Update is called once per frame
    void Update()
    {
        if(timer < spawnRate){
            timer+=Time.deltaTime;
        }
        else{
            newPipe();
            timer=0;
        }
    }
    void newPipe(){
        float LowestPoint=transform.position.y-PipeOffset;
        float HighestPoint=transform.position.y+PipeOffset;
        Instantiate(Pipe, new Vector3(transform.position.x, Random.Range(LowestPoint,HighestPoint),0), transform.rotation);
    }
}
