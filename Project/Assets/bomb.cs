using UnityEngine;
using System.Collections;

public class bomb : MonoBehaviour {

	// Use this for initialization
	bomb () {
	
	}
	
	// Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject original = GameObject.Find("player");
            GameObject copied = Object.Instantiate(original) as GameObject;
            copied.transform.Translate(0, 0, 0);
        }
    }
}
