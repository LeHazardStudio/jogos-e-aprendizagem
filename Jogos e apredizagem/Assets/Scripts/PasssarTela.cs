using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PasssarTela : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void scene()
    {
        SceneManager.LoadScene("Game Scene");     
    }

    public void regra()
    {
        SceneManager.LoadScene("Regras");
    }

    public void voltar()
    {
        SceneManager.LoadScene("Menu");
        GameControl.fasespassadas = 0;
    }

    public void sair()
    {
        Application.Quit();
    }
}
