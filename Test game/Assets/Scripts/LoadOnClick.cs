using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class LoadOnClick : MonoBehaviour {
    private Text text;

	// Use this for initialization
	void Start () {
        text = GameObject.Find("TimeText").GetComponent<Text>();

        string score = PlayerPrefs.GetString("score");
        if (score != "")
        {
            text.text = score;
        }
    }
	
	// Update is called once per frame
	void Update () {
	
	}
    
    public void LoadLevel() {
        Debug.Log("button pushed");
        Application.LoadLevel(1);
    }
}
