using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime;
using UnityEngine;

public class GameControl : MonoBehaviour
{
    GameObject token;
    public List<GameObject> tokensLT = new List<GameObject> { };
    public List<GameObject> tokensJP = new List<GameObject> { };

     List<int> faceIndexesLatin = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
     List<int> faceIndexesJap = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
    public static System.Random rnd = new System.Random();
    public int shuffleNumLT = 0;
    public int shuffleNumJP = 0;
    public int rc;
    int[] visibleFaces = { -1, -2 };


    void Start()
    {

        tokensLT.Add(token);
        tokensLT.Add(token);
        tokensLT.Add(token);
        tokensLT.Add(token);
        tokensLT.Add(token);
        tokensLT.Add(token);
        tokensLT.Add(token);
        tokensLT.Add(token);
        tokensLT.Add(token);
        tokensLT.Add(token);
        tokensJP.Add(token);
        tokensJP.Add(token);
        tokensJP.Add(token);
        tokensJP.Add(token);
        tokensJP.Add(token);
        tokensJP.Add(token);
        tokensJP.Add(token);
        tokensJP.Add(token);
        tokensJP.Add(token);
        tokensJP.Add(token);

        int originalLengthLatin = faceIndexesLatin.Count;
        int originalLenghtJap = faceIndexesJap.Count;
        float yPosition = 2.3f;
        float xPosition = -2.2f;
        for (int i = 0; i < 19; i++)
        {
            shuffleNumLT = rnd.Next(faceIndexesLatin.Count);
            shuffleNumJP = rnd.Next(faceIndexesJap.Count);
            rc = Random.Range(1,3);

            var temp = Instantiate(token, new Vector3(
                xPosition, yPosition, 0),
                Quaternion.identity);
            if (rc == 1)
            {
                if (faceIndexesLatin.Count > 0)
                {
                    temp.GetComponent<MainToken>().faceIndexLT = faceIndexesLatin[shuffleNumLT];
                    tokensLT[faceIndexesLatin[shuffleNumLT]] = temp;
                    faceIndexesLatin.Remove(faceIndexesLatin[shuffleNumLT]);
                    
                }
                else
                {
                    temp.GetComponent<MainToken>().faceIndexJP = faceIndexesJap[shuffleNumJP];
                    tokensJP[faceIndexesJap[shuffleNumJP]] = temp;
                    faceIndexesJap.Remove(faceIndexesJap[shuffleNumJP]);
                    
                }
                
            }
            else if(rc == 2)
            {
                if (faceIndexesJap.Count <= 0)
                {
                    temp.GetComponent<MainToken>().faceIndexLT = faceIndexesLatin[shuffleNumLT];
                    tokensLT[faceIndexesJap[shuffleNumLT]] = temp;
                    faceIndexesLatin.Remove(faceIndexesLatin[shuffleNumLT]);
                    
                }
                else
                {
                    temp.GetComponent<MainToken>().faceIndexJP = faceIndexesJap[shuffleNumJP];
                    tokensJP[faceIndexesJap[shuffleNumJP]] = temp;
                    faceIndexesJap.Remove(faceIndexesJap[shuffleNumJP]);
                    

                }
            }
            xPosition = xPosition + 4;
            if (i == 2 || i == 6 || i == 10 || i == 14)
            {
                yPosition += -5.3f;
                xPosition = -6.2f;
            }
        }
        if (faceIndexesLatin.Count > 0)
        {
            token.GetComponent<MainToken>().faceIndexLT = faceIndexesLatin[0];
        }
        else if (faceIndexesJap.Count > 0) 
        {
            token.GetComponent<MainToken>().faceIndexJP = faceIndexesJap[0];
        }
        
        
    }

    public bool TwoCardsUp()
    {
        bool cardsUp = false;
        if (visibleFaces[0] >= 0 && visibleFaces[1] >= 0)
        {
            cardsUp = true;
        }
        return cardsUp;
    }

    public void AddVisibleFace(int index)
    {
        if (visibleFaces[0] == -1)
        {
            visibleFaces[0] = index;
        }
        else if (visibleFaces[1] == -2)
        {
            visibleFaces[1] = index;
        }
    }

    public void RemoveVisibleFace(int index)
    {
        if (visibleFaces[0] == index)
        {
            visibleFaces[0] = -1;
        }
        else if (visibleFaces[1] == index)
        {
            visibleFaces[1] = -2;
        }
    }

    public bool CheckMatch()
    {
        bool success = false;
        if (visibleFaces[0] == visibleFaces[1])
        {
            tokensLT[visibleFaces[0]].GetComponent<MainToken>().matched = true;
            tokensJP[visibleFaces[0]].GetComponent<MainToken>().matched = true;
            tokensLT[visibleFaces[0]].GetComponent<MainToken>().faceIndexLT = visibleFaces[0];
            tokensJP[visibleFaces[0]].GetComponent<MainToken>().faceIndexJP = visibleFaces[0];
            visibleFaces[0] = -1;
            visibleFaces[1] = -2;
            

            success = true;
        }
       
 
        return success;
    }
        
        private void Awake()
        {
            token = GameObject.Find("Token");
        }
     }

