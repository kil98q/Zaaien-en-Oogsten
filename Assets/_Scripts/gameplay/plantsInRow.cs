using UnityEngine;
using System.Collections;

public class plantsInRow : MonoBehaviour {
    [SerializeField]
    public GameObject[] plants;
    public GameObject[] Plants
    {
        get { return plants; }
    }

    void Awake()
    {
        plants = new GameObject[4];
    }

    /// <summary>
    /// adds a gameobject to the array with plantes
    /// </summary>
    /// <param name="Plant">tha gameobject</param>
    /// <param name="num">place in the array</param>
    public void addToPlants(GameObject Plant,int num)
    {
        plants[num] = Plant;
    }
}
