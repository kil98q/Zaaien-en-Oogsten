﻿using UnityEngine;
using System.Collections;

public class zaai : MonoBehaviour {

    [SerializeField] private plantsInLand plantsHolder;
    //[SerializeField] private GameObject plantObject;
    private GameObject[] plants;
    private GameObject[] plantsTemp;
    public GameObject[] Plants
    {
        get { return plantsTemp; }
    }
    private bool isPlanted = false;
    public bool harvest
    {
        get { return isPlanted;  }
        set { isPlanted = false; }
    }

    void Start()
    {
        plants = new GameObject[plantsHolder._plantes.Length];
        plants = plantsHolder._plantes;
        //plant();
    }

	public void plant(GameObject plantObject)
    {
        if (isPlanted == false)
        {
            isPlanted = true;
            plantsTemp = new GameObject[plants.Length];
            for (int i = 0; i < plants.Length; i++)
            {
                GameObject plant = Instantiate(plantObject);
                plant.transform.parent = plants[i].transform;
                plant.transform.localPosition = new Vector3(0, 0, 0);
                plantsTemp[i] = plant;
                //plants[i] = plantSprite;
            }
        }
    }
}
