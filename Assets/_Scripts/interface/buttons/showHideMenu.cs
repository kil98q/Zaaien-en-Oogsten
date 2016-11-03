using UnityEngine;
using System.Collections;

//enables and disables objects
public class showHideMenu : MonoBehaviour {

    [SerializeField]
    private GameObject menu;

	void Start () {
	menu.SetActive(false);
    }

    /// <summary>
    /// enables the menu
    /// </summary>
    public void show()
    {
        menu.SetActive(true);
    }

    /// <summary>
    /// diables the menu
    /// </summary>
    public void hide()
    {
        menu.SetActive(false);
    }
}

