using UnityEngine;
using System.Collections;

public class PlayerAnim : MonoBehaviour {

	Animator anim;

	void Start(){
		anim = GetComponent<Animator> ();
	}

	void Update(){
		if (Input.GetKeyDown (KeyCode.O)) {
			anim.SetInteger ("State", 1);
		}
		if (Input.GetKeyUp (KeyCode.O)) {
			anim.SetInteger ("State", 0);
		}
		if (Input.GetKeyDown (KeyCode.Z)) {
			anim.SetInteger ("State", 2);
		}
		if (Input.GetKeyUp (KeyCode.Z)) {
			anim.SetInteger ("State", 0);
		}
	}
}
