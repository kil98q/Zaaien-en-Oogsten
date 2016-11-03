using UnityEngine;
using System.Collections;

public class BarProgress : MonoBehaviour
{
    [SerializeField] private float _barDisplay;
    [SerializeField] private Vector2 _pos = new Vector2(140, 20);
    [SerializeField] private Vector2 _size = new Vector2(120, 20);
    private Texture2D _emptyBar;
    private Texture2D _fullBar;
	
    // Use this for GUI 
	void OnGUI ()
    {
        //this draws an empty BAR
        GUI.BeginGroup(new Rect(_pos.x, _pos.y, _size.x, _size.y));
            GUI.Box(new Rect(0, 0, _size.x, _size.y), _emptyBar);

        //this draws a filled BAR
            GUI.BeginGroup(new Rect(0, 0, _size.x * _barDisplay, _size.y));
                GUI.Box(new Rect(0, 0, _size.x, _size.y), _fullBar);
            GUI.EndGroup();
        GUI.EndGroup();
    }

	// Update is called once per frame
	void Update ()
    {
        _barDisplay = Time.time * 0.01f; //empties the bar with 0.05 every frame
	}
}
