using UnityEngine;
using System.Collections;

public class land : MonoBehaviour {
    [SerializeField]
    public int Water
    {
        get { return Water; }
        private set { this.Water = value; }
    }
    [SerializeField]
    public GameObject Plant
    {
        get { return Plant; }
        private set { this.Plant = value; }
    }
    [SerializeField]
    public bool HasPlants
    {
        get { return HasPlants; }
        private set { this.HasPlants = value; }
    }
    public int MaxWater
    {
        get { return MaxWater; }
        private set { this.MaxWater = value; }
    }



    // Use this for initialization
    void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	    
	}
    public void AddWater(int Amount)
    {
        int newWater = Amount + Water;
        if(newWater > MaxWater)
        {
            Water = MaxWater;
        }
        
    }
    public void SetMaxWater(int MaximumWater)
    {
        MaxWater = MaximumWater;
    }
    public void CalculateWater()
    {
        // To be filled in when there is a plant object
    }
    public void AddPlant(GameObject AddedPlant)
    {
        Plant = AddedPlant;
    }
    // Has to return yield aventually
    /*
    public Item[] RemovePlant()
    {
        //Item PlantYield[] = Plant.GetYield();
        DestroyImmediate(Plant);
    }*/

}
