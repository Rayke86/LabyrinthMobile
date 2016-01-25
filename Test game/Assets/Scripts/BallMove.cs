using UnityEngine;
using System.Collections;

public class BallMove : MonoBehaviour {

    public float speed;
    private Rigidbody rigidbody;
    private bool finished;


    // Use this for initialization
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
        finished = false;
        speed = 20.0f;
        
    }

    // Update is called once per frame
    void Update()
    {

    }


    void FixedUpdate()
    {


        if (!finished)
        {
            float x = Input.acceleration.x;
            float y = Input.acceleration.y;
            float z = -Input.acceleration.z;


            Vector3 movement = new Vector3(x, 0.0f, y);
            rigidbody.AddForce(movement * speed);

        }
    }

    void OnTriggerEnter(Collider other)
    {
        switch (other.tag)
        {
            case "hole":
                Debug.Log("Black hole");
                Application.LoadLevel(0);
                break;
            case "finish":
                Debug.Log("YOU WON!!!");
                rigidbody.constraints = RigidbodyConstraints.FreezeAll;
                finished = true;
                break;
        }
    }

    /*void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        body.AddForce(movement * speed);

    }*/
}
