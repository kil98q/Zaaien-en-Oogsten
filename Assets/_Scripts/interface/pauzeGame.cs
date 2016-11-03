using UnityEngine;
using System.Collections;

public class pauzeGame : MonoBehaviour {

    [SerializeField] private GameObject menu;
    [SerializeField] private KeyCode pausekey;
    private bool isPaused = false;

    void Update()
    {
        if (Input.GetKeyDown(pausekey))
        {
            if (isPaused)
            {
                resumeGame();
            }
            else
            {
                pausegame();
            }
        }
    }

    public void pausegame()
    {
        Time.timeScale = 0;
        isPaused = true;
        menu.SetActive(true);
    }

    public void resumeGame()
    {
        Time.timeScale = 1;
        isPaused = false;
        menu.SetActive(false);
    }
}
