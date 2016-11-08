using UnityEngine;
using System.Collections;

public class addSelfToRow : MonoBehaviour {
    [SerializeField] private GameObject row;
    [SerializeField] private int numberInRow;

    void Start () {
        row.GetComponent<plantsInRow>().addToPlants(this.gameObject, numberInRow-1);

	}
}
