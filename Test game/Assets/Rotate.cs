using UnityEngine;
using System.Collections;

public class Rotate : MonoBehaviour {

    public float speed;

    private Rigidbody body;

    // Use this for initialization
    void Start () {
        body = GetComponent<Rigidbody>();
        speed = 1;

	}
	
	// Update is called once per frame
	void Update () {

    }

    void FixedUpdate()
    {

        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 rotation = new Vector3(moveVertical, 0.0f, -moveHorizontal);

        //transform.Rotate(Vector3.right, Space.World);
        transform.RotateAround(Vector3.zero, rotation, speed);

    }
}
