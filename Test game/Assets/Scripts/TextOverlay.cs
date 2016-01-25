using UnityEngine;
using System.Collections;

public class TextOverlay : MonoBehaviour
{

    public GameObject player;

    private Vector3 offset;

    void Start()
    {
        offset = transform.position - player.transform.position;
    }

    void Update()
    {

    }

    void LateUpdate()
    {
        this.transform.position = player.transform.position + offset;
        //transform.position = player.transform.position + offset;
    }
}
