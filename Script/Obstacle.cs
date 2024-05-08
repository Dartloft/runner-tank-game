using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    //Declaro las clases
    PlayerController playermovement;
    PlayerMana playermana;
    // Start is called before the first frame update
    void Start()
    {   //Busco el tipo de objeto
        playermovement = GameObject.FindObjectOfType<PlayerController>();
        playermana = GameObject.FindObjectOfType<PlayerMana>();
    }

    private void OnTriggerEnter(Collider collision) //metodo para la colision del objeto con el personaje
    {
        if(collision.gameObject.name == "Player") //si colisiona con el jugador 
        {
            //Muere el personaje
            playermovement.Die();
            //luego de la muerte aparece el menu
            playermana.ToggleEndMenu();
        }
    }

    // Update is called once per frame
   private void Update()
    {
        
    }
}
