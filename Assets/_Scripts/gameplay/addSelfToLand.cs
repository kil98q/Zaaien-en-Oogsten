using UnityEngine;
using System.Collections;

public class addSelfToLand : MonoBehaviour {

    [SerializeField] private GameObject land;
    private GameObject[] plants;

	void Start () {
        plants = GetComponent<plantsInRow>().Plants;
        land.GetComponent<plantsInLand>();
	}
	
}
