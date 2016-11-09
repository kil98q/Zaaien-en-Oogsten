using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Inventory : MonoBehaviour {
    [SerializeField]private List<Item> storedItems;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    public void Add(Item _item)
    {
        storedItems.Add(_item);
    }
}
