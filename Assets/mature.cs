using UnityEngine;
using System.Collections;

public class mature : MonoBehaviour {
    [SerializeField] private float matureSpeed;
    private float maturety;
    public float Maturety
    {
        get { return maturety; }
    }
    // Use this for initialization
    void Start()
    {
        maturety = 0;
    }

    // Update is called once per frame
    void Update()
    {
        maturety += Time.deltaTime * matureSpeed;
       // print(maturety);
    }
}
