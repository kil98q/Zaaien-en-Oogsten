using UnityEngine;
using System.Collections;

public class SeasonCounter : MonoBehaviour {

	[SerializeField] private float speed; //Geef in unity de snelheid aan
	private float timeCounter = 0f; //Houdt de tijd van het spel
	private int year = 0; //Houdt het jaar bij

	void Update() {
		timeCounter += speed * Time.deltaTime; //telt de tijd op
		//Als de tijd meer dan 60 is, wordt er een jaar opgeteld en gaat de tijd terug naar 0
		if (timeCounter > 60) {
			year += 1;
			timeCounter = 0;
		}
	}

	//Geeft het seizoen aan voor andere scripts
	public int Season(){
		//Als de tijd tussen de 0 en 15 zit, wordt 1 terug gegeven
		if (timeCounter > 0 && timeCounter < 15) {
			return 1;
		}
		//Als de tijd tussen de 15 en 30 zit, wordt 2 terug gegeven
		else if (timeCounter > 15 && timeCounter < 30) {
			return 2;
		}
		//Als de tijd tussen de 30 en 45 zit, wordt 3 terug gegeven
		else if (timeCounter > 30 && timeCounter < 45) {
			return 3;
		}
		//Als de tijd meer dan 45, wordt 4 terug gegeven
		else {
			return 4;
		}
	}

}
