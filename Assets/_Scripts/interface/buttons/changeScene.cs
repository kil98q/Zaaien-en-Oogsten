using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

//script that changes a scene.
public class changeScene : MonoBehaviour {


    public string sceneName;

    /// <summary>
    /// loads another scene
    /// </summary>
    public void change ()
    {
        SceneManager.LoadScene(sceneName);
    }
}
