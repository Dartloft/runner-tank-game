using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    //declaro las variables
   public int score;
    public static GameManager inst;
    // Start is called before the first frame update

    public Text scoreText;

    public void incrementScore()//Metodo para incrementar el puntaje
    {
        score++;//incrementa de a 1 punto
        scoreText.text = "SCORE: "+score;//texto que muestra el score
    }

    private void Awake()
    {
        inst = this;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
