using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiddleScript : MonoBehaviour
{
    public birdScript Bird;
    public LogicScript logic;
    // Start is called before the first frame update
    void Start()
    {
        logic= GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
        Bird= GameObject.FindGameObjectWithTag("Bird").GetComponent<birdScript>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnTriggerEnter2D(Collider2D Collisions){
        if(Bird.getBirdAlive()){
            logic.addScore(1);
        }
    }
}
