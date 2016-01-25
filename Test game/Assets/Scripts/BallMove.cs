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
            Vector3 movement = new Vector3(Input.acceleration.x, 0.0f, -Input.acceleration.z);
            rigidbody.AddForce(movement * speed);
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
