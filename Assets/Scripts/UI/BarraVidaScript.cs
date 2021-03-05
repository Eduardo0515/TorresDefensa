using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class BarraVidaScript : MonoBehaviour
{
    [Tooltip("Vida maxima del jugador")]
    public int VidaMaxima;

    //referencia de la barra de relleno en UI de Unity
    private Image relleno;

    //vida actual del jugador
    private int vidaActual;
    void Start()
    {
        relleno = GetComponent<Image>();
        vidaActual = VidaMaxima;

//para probar
  //  vidaActual= 50;

        UpdateBarraVida();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public bool aplicarHerida(int herida){

        //aplica el daño a la vida actual
        vidaActual -= herida;

        //si me queda vida, debo actualizar vida actual
        if(vidaActual > 0){
            Debug.Log("Comiendo comiendo mmm"); 
            Debug.Log(vidaActual); 
            UpdateBarraVida();
            return false;

        }      
        vidaActual=0;

        UpdateBarraVida();
        return true;
    }


    void UpdateBarraVida(){

        // calcula el porcentaje de vida que queda (da un valor entre 0 y 1)
        float porcentaje =vidaActual *1.0f/ VidaMaxima;

        // aplica el porcentaje al relleno de la barra de vida
        relleno.fillAmount= porcentaje;

    }
}
