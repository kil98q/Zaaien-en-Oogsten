using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class imageChange : MonoBehaviour {

    [SerializeField] private Sprite normal;
    [SerializeField] private Sprite hover;
    private Image image;

    void Start()
    {
        image = GetComponent<Image>();
    }


    /// <summary>
    /// changes image to another image.
    /// </summary>
    public void hoverOverButton()
    {
        
        image.sprite = hover;
    }

    /// <summary>
    /// changes image to the start image.
    /// </summary>
    public void noHover()
    {
        image.sprite = normal;
    }

}
