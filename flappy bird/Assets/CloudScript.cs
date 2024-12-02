using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudScript : MonoBehaviour
{
    public float deadzone=-20;
    public LogicScript logic;
    public int Speed;
    // Start is called before the first frame update
    void Start()
    {
        logic= GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();   
    }

    // Update is called once per frame
    void Update()
    {
        Speed=Random.Range(3,10);
        transform.position = transform.position + (Vector3.left*Speed)*Time.deltaTime;
        if(transform.position.x < deadzone){
            Destroy(gameObject);
        }
    }
}
