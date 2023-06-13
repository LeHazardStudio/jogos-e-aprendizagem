using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime;
using UnityEngine;

public class GameControl : MonoBehaviour
{
    GameObject token;
    List<GameObject> tokens = new List<GameObject> {};
    List<int> faceIndexes = new List<int> {0, 1, 2, 3, 4, 5, 6, 7, 8, 9};
    public static System.Random rnd = new System.Random();
    public int shuffleNum = 0;
    int[] visibleFaces = { -1, -2 };
    
    void Start()
    {
        tokens.Add(token);
        tokens.Add(token);
        tokens.Add(token);
        tokens.Add(token);
        tokens.Add(token);
        tokens.Add(token);
        tokens.Add(token);
        tokens.Add(token);
        tokens.Add(token);
        tokens.Add(token);
        int originalLength = faceIndexes.Count;
        float yPosition = 2.3f;
        float xPosition = -2.2f;
        for(int i = 0; i < 9; i++)
        {
            shuffleNum = rnd.Next(faceIndexes.Count);

            var temp = Instantiate(token, new Vector3(
                xPosition, yPosition, 0),
                Quaternion.identity);
            
            temp.GetComponent<MainToken>().faceIndex = faceIndexes[shuffleNum];
            tokens[shuffleNum] = temp;
            faceIndexes.Remove(faceIndexes[shuffleNum]);
            xPosition = xPosition + 4;
            if(i == 3)
            {
                yPosition += -5.3f;
                xPosition = -6.2f;
            }
        }
        token.GetComponent<MainToken>().faceIndex = faceIndexes[0];
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

    public bool CheckMatch(int index, int indexAnt)
    {
        bool success = false;
        if (index == 0 && visibleFaces[0] + visibleFaces[1] == 5)
        {
            visibleFaces[0] = -1;
            visibleFaces[1] = -2;
            tokens[indexAnt].GetComponent<MainToken>().matched = true;
            
            success = true;
        }
        if (index == 1 && visibleFaces[0] + visibleFaces[1] == 7)
        {
            visibleFaces[0] = -1;
            visibleFaces[1] = -2;
            success = true;
            tokens[indexAnt].GetComponent<MainToken>().matched = true;
        }
        if (index == 2 && visibleFaces[0] + visibleFaces[1] == 9)
        {
            visibleFaces[0] = -1;
            visibleFaces[1] = -2;
            success = true;
            tokens[indexAnt].GetComponent<MainToken>().matched = true;
        }
        if (index == 3 && visibleFaces[0] + visibleFaces[1] == 11)
        {
            visibleFaces[0] = -1;
            visibleFaces[1] = -2;
            success = true;
            tokens[indexAnt].GetComponent<MainToken>().matched = true;
        }
        if (index == 4 && visibleFaces[0] + visibleFaces[1] == 13)
        {
            visibleFaces[0] = -1;
            visibleFaces[1] = -2;
            success = true;
            tokens[indexAnt].GetComponent<MainToken>().matched = true;
        }
        if (index == 5 && visibleFaces[0] - visibleFaces[1] == 5)
        {
            visibleFaces[0] = -1;
            visibleFaces[1] = -2;
            success = true;
            tokens[indexAnt].GetComponent<MainToken>().matched = true;
        }
        if (index == 6 && visibleFaces[0] - visibleFaces[1] == 5)
        {
            visibleFaces[0] = -1;
            visibleFaces[1] = -2;
            success = true;
            tokens[indexAnt].GetComponent<MainToken>().matched = true;
        }
        if (index == 7 && visibleFaces[0] - visibleFaces[1] == 5)
        {
            visibleFaces[0] = -1;
            visibleFaces[1] = -2;
            success = true;
            tokens[indexAnt].GetComponent<MainToken>().matched = true;
        }
        if (index == 8 && visibleFaces[0] - visibleFaces[1] == 5)
        {
            visibleFaces[0] = -1;
            visibleFaces[1] = -2;
            success = true;
            tokens[indexAnt].GetComponent<MainToken>().matched = true;

        }
        if (index == 9 && visibleFaces[0] - visibleFaces[1] == 5)
        {
            visibleFaces[0] = -1;
            visibleFaces[1] = -2;
            success = true;
            tokens[indexAnt].GetComponent<MainToken>().matched = true;
        }
       

        return success;
    }
    private void Awake()
    {
        token = GameObject.Find("Token");
    }
}
