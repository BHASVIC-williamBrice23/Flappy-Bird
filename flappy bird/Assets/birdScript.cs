using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class birdScript : MonoBehaviour
{
    public Rigidbody2D myRigidBody;
    public int Strength;
    public LogicScript logic;
    public int t=1;
    public int c=13;
    public int power=20;
    public bool BirdAlive= true;
    private int counter=0;
    // Start is called before the first frame update
    void Start()
    {
        logic= GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && BirdAlive){
            myRigidBody.velocity = Vector2.up * Strength;
            if(transform.rotation.eulerAngles.z<30 || transform.rotation.eulerAngles.z>330){
                transform.Rotate(0, 0, power);
            }
            else{
                
            }
        }
        else{
            if((transform.rotation.eulerAngles.z>340 || transform.rotation.eulerAngles.z<50 )&& counter<=0){
                transform.Rotate(0, 0, -1);
                counter=c;
            }
            else{
                counter-=t;
            }
            
        }
        if(transform.position.y>4.75 || transform.position.y<-4.75){
            logic.gameOver();
            BirdAlive=false;
        }
    }
    public void OnCollisionEnter2D(Collision2D Collision){
        logic.gameOver();
        BirdAlive=false;
    }
    public bool getBirdAlive(){
        return BirdAlive;
    }
}
