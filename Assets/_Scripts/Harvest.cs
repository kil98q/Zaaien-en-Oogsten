using UnityEngine;
using System.Collections;

public class Harvest : MonoBehaviour {
    /* _cursorWorld; // Will be changed when the input handler is ready
    Collider2D Collisionbox;
<<<<<<< HEAD

	// Update is called once per frame
	void Update () {
        Collisionbox = GetComponent<Collider2D>();
	    _cursorWorld = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        //if (Collisionbox.)
        {

        }
	}
=======
    
    Ray ray;
    
	// Update is called once per frame
	void Update () {
        ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit2D hit = Physics2D.Raycast(ray.origin, ray.direction, Mathf.Infinity);

    }
    private void PlayAnimation()
    {

    }
    private Item[] HarvestLand(GameObject land)
    {
        return land.GetComponent<land>().RemovePlant();
    }
>>>>>>> f70e1c4a49b2e5112d9287efe0a5a65bf3c2cf24*/
}
