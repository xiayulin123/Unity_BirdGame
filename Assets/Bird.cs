using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
    public Rigidbody2D myBody;
    public float flapSrength;
    public logic logic;
    public bool birdIsAlive = true;
    // Start is called before the first frame update
    void Start()
    {

        logic = GameObject.FindGameObjectWithTag("logic").GetComponent<logic>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) == true && birdIsAlive)
        {
            myBody.velocity = Vector2.up *  flapSrength;
        }
        if(transform.position.y > 15 || transform.position.y < -15)
        {
            logic.gameOver();
            birdIsAlive = false;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
        birdIsAlive = false;
    }
}
