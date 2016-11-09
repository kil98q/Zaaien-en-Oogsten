using UnityEngine;
using System.Collections;

public class Harvest : MonoBehaviour {
    private Vector3 _cursorWorld; // Will be changed when the input handler is ready
    private Collider2D Collisionbox;
    private GameObject land;
    [SerializeField] private GameObject InventoryObject;

	// Update is called once per frame
	void Update () {
        Collisionbox = GetComponent<Collider2D>();
	    _cursorWorld = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        //if (Collisionbox.)
        {

        }
	}
    private void PlayAnimation()
    {

    }
    private void HarvestLand()
    {
        Item[] looot = land.GetComponent<land>().RemovePlant();
        foreach(Item loot in looot)
        {
            InventoryObject.GetComponent<Inventory>().Add(loot);
        }
    }
}
