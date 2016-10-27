using UnityEngine;
using System.Collections;

public class Harvest : MonoBehaviour {
    Vector3 _cursorWorld; // Will be changed when the input handler is ready
    Collider2D Collisionbox;

	// Update is called once per frame
	void Update () {
        Collisionbox = GetComponent<Collider2D>();
	    _cursorWorld = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        //if (Collisionbox.)
        {

        }
	}
}
