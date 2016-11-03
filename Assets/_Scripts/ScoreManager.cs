using UnityEngine;
using UnityEngine.UI; // <-- add UI library 
using System.Collections;

public class ScoreManager : MonoBehaviour
{
    private int _score;
    private Text _text;

	// Use this for initialization
	void Awake ()
    {
        _text = GetComponent<Text>(); //add the component to the Text method
        _score = 0; //score is set to 0
	}
	
	// Update is called once per frame
	void Update ()
    {
        _text.text = "Revenue: " + _score; //view the score text on screen
	}

    public void AddPoints(int _amount)
    {
        _score += _amount;
    }

    public void RemovePoints(int _amount)
    {
        _score -= _amount;
    }
}