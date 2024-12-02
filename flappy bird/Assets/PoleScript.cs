using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoleScript : MonoBehaviour
{
    public float Speed;
    public float deadzone=-20;
    public LogicScript logic;

    // Start is called before the first frame update
    void Start(){
        logic= GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
        Speed=logic.getSpeed();
    }

    // Update is called once per frame
    void Update()
    {
       
        transform.position = transform.position + (Vector3.left*Speed)*Time.deltaTime;
        if(transform.position.x < deadzone){
            Destroy(gameObject);
        }

    }
}
