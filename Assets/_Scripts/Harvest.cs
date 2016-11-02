using UnityEngine;
using System.Collections;

public class Harvest : MonoBehaviour {
    Vector3 _cursorWorld; // Will be changed when the input handler is ready
    Collider2D Collisionbox;
    
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
}
