using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainToken : MonoBehaviour
{
    GameObject gameControl;
    SpriteRenderer spriteRenderer;
    public Sprite[] facesLatin;
    public Sprite[] facesJap;
    public Sprite back;
    public int faceIndexLT = -1;
    public int faceIndexJP = -1;

    public bool matched = false;

    public void OnMouseDown()
    {
        if(matched == false)
        {
            if (spriteRenderer.sprite == back)
            {
                if (gameControl.GetComponent<GameControl>().TwoCardsUp() == false)
                {
                    if (faceIndexJP != -1)
                    {
                        spriteRenderer.sprite = facesJap[faceIndexJP];
                        gameControl.GetComponent<GameControl>().AddVisibleFace(faceIndexJP);
                        matched = gameControl.GetComponent<GameControl>().CheckMatch();
                    }
                    else if (faceIndexLT != -1)
                    {
                        spriteRenderer.sprite = facesLatin[faceIndexLT];
                        gameControl.GetComponent<GameControl>().AddVisibleFace(faceIndexLT);
                        matched = gameControl.GetComponent<GameControl>().CheckMatch();
                    }
                    

                }
            }
            else
            {
                if (faceIndexJP != -1)
                {
                    spriteRenderer.sprite = back;
                    gameControl.GetComponent<GameControl>().RemoveVisibleFace(faceIndexJP);
                }
                else if (faceIndexLT != -1)
                {
                    spriteRenderer.sprite = back;
                    gameControl.GetComponent<GameControl>().RemoveVisibleFace(faceIndexLT);
                }
                
            }
        }
        
        
    }

    

    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        gameControl = GameObject.Find("GameControl");
    }
}
