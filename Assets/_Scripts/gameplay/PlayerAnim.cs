using UnityEngine;
using System.Collections;

public class PlayerAnim : MonoBehaviour {

	Animator anim;
	private int anime = 0;

	void Start(){
		//Verandert de variabele "anim" naar de component animator
		anim = GetComponent<Animator> ();
	}

	public void Zaai(){
		anime = 1;
		anim.SetInteger ("Anime", anime);
		StartCoroutine (Zaaien ());
	}
		
	IEnumerator Zaaien () {

		while (anime == 1){

			yield return new WaitForSeconds (0.69f);
			anime = 0;
			anim.SetInteger ("Anime", anime);
		}
	}

	public void Oogst(){
		anime = 2;
		anim.SetInteger ("Anime", anime);
		StartCoroutine (Oogsten ());
	}

	IEnumerator Oogsten () {

		while (anime == 2){

			yield return new WaitForSeconds (1.3f);
			anime = 0;
			anim.SetInteger ("Anime", anime);
		}
	}
}
