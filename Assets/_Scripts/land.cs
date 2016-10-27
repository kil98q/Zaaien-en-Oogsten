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
        if(newWater > 100)
        {
            Water = MaxWater;
        }
        
    }
    public void CalculateWater()
    {

    }
}
