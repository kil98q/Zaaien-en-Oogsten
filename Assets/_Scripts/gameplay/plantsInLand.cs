using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class plantsInLand : MonoBehaviour {

    [SerializeField] private GameObject[] Rows;
    [SerializeField] private GameObject[] plants;
    private int plantsFilled;
	
    void Start()
    {
        getPlantes();
    }

    /// <summary>
    /// puts the all the plants in an array
    /// </summary>
    private void getPlantes()
    {
        plantsFilled = 0;
        plants = new GameObject[16];
        for (int i = 0; i < Rows.Length; i++)
        {
            GameObject[] T = Rows[i].GetComponent<plantsInRow>().Plants;
            for (int j = 0; j < T.Length; j++)
            {
                plants[plantsFilled] = T[j];
                plantsFilled++;
            }
        }

    }
	
}
