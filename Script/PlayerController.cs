using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //Declaracion de variables y de clases
    public float speed = 5;
    public Rigidbody rb;

    float horizontalInput;
    public float horizontalMultiplier = 2;

    private bool isalive = false;

    public PlayerMana playermana;

    // Start is called before the first frame update
    void Start()
    {
       
      
    }

    private void FixedUpdate()
    {
        if(isalive)return;
        //Mueve hacia delante 
        Vector3 forwardMove = transform.forward * speed * Time.fixedDeltaTime;
        Vector3 horizontalMove = transform.right * horizontalInput * speed * Time.fixedDeltaTime * horizontalMultiplier;
        rb.MovePosition(rb.position + forwardMove + horizontalMove);
    }


    // Update is called once per frame
   private void Update()
    {
        //mueve al personaje horizontalmente
        horizontalInput = Input.GetAxis("Horizontal");


        if(transform.position.y < -5)
        {
            Die();
        }

    }



    public void Die()//metodo de la muerte
    {
       isalive = true; // bandera si sigue vivo sigue si no aparece el menu
        //resetea el juego
        // Invoke("Restart", 2);
       playermana.ToggleEndMenu();
    }

    public void Restart()//Metodo que resetea el escenario
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        
    }
  
}
