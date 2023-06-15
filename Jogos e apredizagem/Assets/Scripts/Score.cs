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
        if (Timer.Tempo <= 60 && Timer.Tempo >= 41)
        {
            image.sprite = star3;
        }
        else if (Timer.Tempo <= 40 && Timer.Tempo >= 21)
        {
            image.sprite = star2;
        }
        else if (Timer.Tempo <= 20 && Timer.Tempo >= 1)
        {
            image.sprite = star;
        }
    }
}
