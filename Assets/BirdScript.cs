using System.Collections.Specialized;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    //RigidBody2D communicates to the component; "myRigidbody is a name to refer to.
    public Rigidbody2D myRigidbody;

    //number w/ a decimal
    public float flapStrength;  //gives new field in Unity script

    public LogicScript logic;

    public bool birdAlive = true;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>(); //connecting PopeMiddleScript.cs with the LogicScript.cs

    }

    // Update is called once per frame
    void Update()
    {
        //Input is talking to Unity's input system.  If the space bar has been pressed down on this frame.
        if(Input.GetKeyDown(KeyCode.Space) == true && birdAlive)
        {
            //vector gives a position in a 2D space; multiply by 10 to send the bird flying in the air.
            myRigidbody.linearVelocity = Vector2.up * flapStrength;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
        birdAlive = false;
    }
}
