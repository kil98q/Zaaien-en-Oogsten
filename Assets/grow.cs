using UnityEngine;
using System.Collections;

public class grow : MonoBehaviour {

    [SerializeField] private mature maturetyCounter;

    [SerializeField] private float minScale;
    [SerializeField] private float maxScale;
    [SerializeField] private float completlyMature;
    private float maturety;
    private float scale;
    private float y;

	// Use this for initialization
	void Start () {
        y = transform.position.y;
        maturety = 0;
	}
	
	// Update is called once per frame
	void Update () {
        maturety = maturetyCounter.Maturety;
        scale = minScale + (maxScale - minScale) / completlyMature * maturety;
        if (scale > maxScale)
        {
            scale = maxScale;
        }
        transform.localScale = new Vector3(scale, scale, scale);
        transform.position = new Vector3(transform.position.x, y + transform.localScale.y / 2, 0);
    }
}
