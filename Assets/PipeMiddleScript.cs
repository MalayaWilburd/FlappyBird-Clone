using UnityEngine;

public class PipeMiddleScript : MonoBehaviour
{

    public LogicScript logic;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>(); //connecting PopeMiddleScript.cs with the LogicScript.cs
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 3)  //this makes the function more versatile so you can add more numbers to the score; Ex: can increment by 5 if needed
        {
            logic.addScore(1);
        }
    }
}