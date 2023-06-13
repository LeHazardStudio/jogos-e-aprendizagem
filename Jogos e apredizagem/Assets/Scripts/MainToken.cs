using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainToken : MonoBehaviour
{
    GameObject gameControl;
    SpriteRenderer spriteRenderer;
    public Sprite[] faces;
    public Sprite back;
    public int faceIndex;
    public bool matched = false;

    public void OnMouseDown()
    {
        if(matched == false)
        {
            if (spriteRenderer.sprite == back)
            {
                if (gameControl.GetComponent<GameControl>().TwoCardsUp() == false)
                {
                    spriteRenderer.sprite = faces[faceIndex];
                    gameControl.GetComponent<GameControl>().AddVisibleFace(faceIndex);
                    if (faceIndex == 0)
                    {
                        matched = gameControl.GetComponent<GameControl>().CheckMatch(faceIndex, faceIndex + 5);
                    }
                    if (faceIndex == 1)
                    {
                        matched = gameControl.GetComponent<GameControl>().CheckMatch(faceIndex, faceIndex + 5);
                    }
                    if (faceIndex == 2)
                    {
                        matched = gameControl.GetComponent<GameControl>().CheckMatch(faceIndex, faceIndex + 5);
                    }
                    if (faceIndex == 3)
                    {
                        matched = gameControl.GetComponent<GameControl>().CheckMatch(faceIndex, faceIndex + 5);
                    }
                    if (faceIndex == 4)
                    {
                        matched = gameControl.GetComponent<GameControl>().CheckMatch(faceIndex, faceIndex + 5);
                    }
                    if (faceIndex == 5)
                    {
                        matched = gameControl.GetComponent<GameControl>().CheckMatch(faceIndex, faceIndex - 5);
                    }
                    if (faceIndex == 6)
                    {
                        matched = gameControl.GetComponent<GameControl>().CheckMatch(faceIndex, faceIndex - 5);
                    }
                    if (faceIndex == 7)
                    {
                        matched = gameControl.GetComponent<GameControl>().CheckMatch(faceIndex, faceIndex - 5);
                    }
                    if (faceIndex == 8)
                    {
                        matched = gameControl.GetComponent<GameControl>().CheckMatch(faceIndex, faceIndex - 5);
                    }
                    if (faceIndex == 9)
                    {
                        matched = gameControl.GetComponent<GameControl>().CheckMatch(faceIndex, faceIndex - 5);
                    }

                }
            }
            else
            {
                spriteRenderer.sprite = back;
                gameControl.GetComponent<GameControl>().RemoveVisibleFace(faceIndex);
            }
        }
        
        
    }

    

    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        gameControl = GameObject.Find("GameControl");
    }
}
