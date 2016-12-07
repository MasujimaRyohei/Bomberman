using UnityEngine;
using System.Collections;

public class move : MonoBehaviour {

    float spd = 0.5f;
    Vector3 pos;
	// Use this for initialization
    void Start()
    {
      //  float spd = 5.0f
    }
	
	// Update is called once per frame
	void Update () 
    {
        this.transform.Rotate(1, 1, 1);
        pos = this.transform.position;

	    if(Input.GetKey(KeyCode.RightArrow))
        {
            pos.x += spd;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            pos.x -= spd;
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            pos.y += spd;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            pos.y -= spd;
        }
        this.transform.position = pos;
	}
}
