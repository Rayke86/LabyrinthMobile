using UnityEngine;

public class BallMove : MonoBehaviour
{

    public float speed;
    private Rigidbody rigidbody;
    private Vector3 start;
    private bool finished;
    public TextMesh text;

    private float time;


    // Use this for initialization
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
        start = rigidbody.position;
        finished = false;
        speed = 20.0f;

    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        text.text = "High Score: \n Time: "+ getTime();

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
                transform.position = start;//new Vector3(9.14f, 0.780f, -8.72f);
                rigidbody.isKinematic = true;
                rigidbody.velocity = Vector3.zero;
                rigidbody.isKinematic = false;
                
                break;
            case "Finish":
                Debug.Log("YOU WON!!!");
                finished = true;
                text.text = "High Score: \n Time: " + getTime();
                PlayerPrefs.SetString("score", getTime());
                Application.LoadLevel(0);
                break;
        }
    }

    private string getTime()
    {
        string timeAsString = "00:00:00";
        string h = "00";
        string m = "00";
        string s = "00";


        int hours = (int)time / 3600;
        if(hours < 10){
            h = "0" + hours;
        }
        else { h = hours + ""; }

        int minutes = (int)time / 60;
        if (minutes < 10){
            m = "0" + minutes;
        }
        else { m = minutes + ""; }

        int seconds = (int)time % 60;
        if (seconds < 10){
            s = "0" + seconds;
        }
        else { s = seconds + ""; }

        timeAsString = h + ":" + m + ":" + s;
        
        return timeAsString;
    }
}
