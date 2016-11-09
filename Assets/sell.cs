using UnityEngine;
using System.Collections;

public class sell : MonoBehaviour {

    [SerializeField] private zaai zaai;

    private GameObject[] plants;

	// Use this for initialization
	void Start () {
        
	}
	
	public void sellAllPlants()
    {
        plants = zaai.Plants;
        for (int i = 0; i < plants.Length; i++)
        {
            plants[i].GetComponent<worth>().sell();
            
        }
    }
}
