using UnityEngine;
using System.Collections;

public class worth : MonoBehaviour {

    [SerializeField] private mature matureHolder;
    [SerializeField] private float plantWorth;
    [SerializeField] private float[] bestMaturety;
    [SerializeField] private ScoreManager buyer;
    private float maturety;
    


	// Use this for initialization
	void Start () {
        buyer = GameObject.Find("Score Text").GetComponent<ScoreManager>();
        maturety = matureHolder.Maturety;
	}
	
    public void sell()
    {
        float currentWorth;
        maturety = matureHolder.Maturety;
        if (maturety < bestMaturety[0])
        {
            currentWorth = plantWorth / bestMaturety[0] * maturety;
        }
        else if(maturety > bestMaturety[1])
        {
            currentWorth = plantWorth - plantWorth / bestMaturety[0] * (maturety - bestMaturety[0]);
            if(currentWorth < 0)
            {
                currentWorth = 0;
            }
        }
        else
        {
            currentWorth = plantWorth;
        }

        buyer.AddPoints((int)Mathf.Round(currentWorth));

        Destroy(this.gameObject);
    }
}
