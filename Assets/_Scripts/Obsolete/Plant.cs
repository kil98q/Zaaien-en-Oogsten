using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Plant : MonoBehaviour {
    //Variables
    [SerializeField]private Texture PlantSprite;
    private Item Seed;
    [SerializeField]private Item[] yield;
    private GameObject[] Plants;
    private int growthStatus;



    // Needed to get the plant objects in this plants object
	void Start () {
        Plants = GetPlants();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    public Plant(Item Seed)
    {
        this.Seed = Seed;
    }
    private GameObject[] GetPlants()
    {
        GameObject[] PlantList;
        PlantList = GetComponentsInChildren<GameObject>();
        return PlantList;
    }
    private void CalculateYield()
    {
        List<Item> tempYield = new List<Item>();
        if (growthStatus>1)
        {
            tempYield.Add(Seed);
        }
        if (growthStatus > 2)
        {
            tempYield.Add(Seed);
            land test = new land();

        }
    }

    private void SetSeedSprite(GameObject[] _Plants, Item seed)
    {
         //foreach(planty in)
    }
    public Item[] GetYield()
    {
        CalculateYield();
        return yield;
    }
}
