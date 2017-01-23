using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipControl : MonoBehaviour {

public float speedX  = 8.0f;
public float speedY = 50.0f;

	void Update () {

		var x = Input.GetAxis("Horizontal") * Time.deltaTime * speedX; //movement left and right
        var z = Input.GetAxis("Vertical") * Time.deltaTime * speedY; //movement up and down
		 transform.Translate(0, x, z);

        if (transform.position.y > 5.4f) //if we move our ship greater than y position 5.4, move it back to 5.4
        	transform.position = new Vector3( transform.position.x , 5.4f); //keep x the same
        else if( transform.position.y < -5.4f) 
        	transform.position = new Vector3 (transform.position.x , -5.4f);
        else if( transform.position.x < -12.45f)
        	transform.position = new Vector3 (-12.45f , transform.position.y); 
        else if(transform.position.x > -8.5f)
        	transform.position = new Vector3(-8.5f, transform.position.y);
        
     }
}
