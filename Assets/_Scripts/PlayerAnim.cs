using UnityEngine;
using System.Collections;

public class PlayerAnim : MonoBehaviour {

	Animator anim;

	void Start(){
		//Verandert de variabele "anim" naar de component animator
		anim = GetComponent<Animator> ();
	}

	void Update(){
		//Terwijl de knop "O" wordt ingerukt, wordt de oogst animatie afgespeeldt
		if (Input.GetKeyDown (KeyCode.O)) {
			anim.SetInteger ("State", 1);
		}
		//Als de knop "O" wordt losgelaten, gaat de animatie terug naar de idle
		if (Input.GetKeyUp (KeyCode.O)) {
			anim.SetInteger ("State", 0);
		}
		//Terwijl de knop "Z" wordt ingerukt, wordt de zaai animatie afgespeeldt
		if (Input.GetKeyDown (KeyCode.Z)) {
			anim.SetInteger ("State", 2);
		}
		//Als de knop "Z" wordt losgelaten, gaat de animatie terug naar de idle
		if (Input.GetKeyUp (KeyCode.Z)) {
			anim.SetInteger ("State", 0);
		}
	}
}
