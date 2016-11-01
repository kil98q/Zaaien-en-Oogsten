using UnityEngine;
using System.Collections;

public class Plant : MonoBehaviour {
    //Variables
    [SerializeField]private Texture PlantSprite;
    Item Seed;
    GameObject[] Plants;

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
    public GameObject[] GetPlants()
    {
        GameObject[] PlantList;
        PlantList = GetComponentsInChildren<GameObject>();
        return PlantList;
    }

    private void SetSeedSprite(GameObject[] _Plants, Item seed)
    {
         //foreach(planty in)
    }
}
