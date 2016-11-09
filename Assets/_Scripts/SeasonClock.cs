using UnityEngine;
using System.Collections;

public class SeasonClock : MonoBehaviour
{
    private float _movePointer = (360f / 60f /1000f);
    [SerializeField] private Transform _pointer;
    [SerializeField] private float _speed =1f;
    private float lastTick = 0;
    private float totalms = 0;
	
	// Update is called once per frame
	void FixedUpdate ()
    {
        System.DateTime _time = System.DateTime.Now;
        float currentTick = _time.Millisecond; //currentTick gaat per milli seconde

        if (currentTick < lastTick) //als currentTick kleiner is dan lastTick (0)
        {
            currentTick += 1000; //currentTick wordt verhoogd naar 1000
        }

        float frame = currentTick - lastTick; //het verschil berekenen tussen current and last
        totalms += frame; //totalms = 0 elke keer optellen met frame (current - last)

        _pointer.localRotation = Quaternion.Euler(0f, 0f, -totalms * _movePointer * _speed); //de wijser 360 graden bewegen op de Z-axis
        lastTick = _time.Millisecond;


       


    }
}
