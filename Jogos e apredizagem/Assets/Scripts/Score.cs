using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    
    public TMP_Text scoretext;
    public Sprite star3;
    public Sprite star2;
    public Sprite star;
    public Image image;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GameControl.fasespassadas == 3)
        {
            image.sprite = star3;
        }
        else if (GameControl.fasespassadas == 2)
        {
            image.sprite = star2;
        }
        else if (GameControl.fasespassadas == 1)
        {
            image.sprite = star;
        }
    }
}
