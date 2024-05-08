using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class PlayerMana : MonoBehaviour
{
    // Start is called before the first frame update

 

    void Start()
    {
        gameObject.SetActive(false); //se activa o se desactiva la vista del menu   
    }

    // Update is called once per frame
    void Update()
    {
     
    }

    public void ToggleEndMenu()//Menu de reinicio
    {
        gameObject.SetActive(true);
    }
   
    public void Restart()//Metodo de reinicio con el boton de reinicio del menu de gameover
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void ToMenu()//quit va al menu de vuelta
    {
        SceneManager.LoadScene("Menu");
    }
}
