using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MetaPuerta : MonoBehaviour
{
    public AudioClip puertaAuido;
    public AudioSource audioSource;
    public Animator puertaAnim;


    public int puntajeMinimo;
    // public int keysMinimo;

    public bool evaluarPuntaje;
    // public bool evaluarLlaves;
    // public bool evaluarPregunta;

    // public GameObject panelPregunta;


    private void OnCollisionEnter2D(Collision2D collision)
    {
        //Solo detecta colisiones del Player
        if (collision.gameObject.CompareTag("Player"))
        {
            if (evaluarPuntaje)
            {
                //Encuentro el objeto Puntaje en el juego
                GameObject puntaje = GameObject.FindObjectOfType<Puntaje>().gameObject;
                //si el puntaje es cierto valor
                if (puntaje.GetComponent<Puntaje>().PuntajeTotal >= puntajeMinimo)
                {
                    audioSource.PlayOneShot(puertaAuido);
                    //ejecutar aniamcion "door"
                    puertaAnim.Play("door");
                }
                else
                {
                    Debug.Log("Te faltan monedas por conseguir.");
                }
            }
            // else if (evaluarLlaves)
            // {
            //     //Encuentro el objeto Puntaje en el juego
            //     GameObject llaves = GameObject.FindObjectOfType<KeysCanvas>().gameObject;
            //     //si el puntaje es cierto valor
            //     if (llaves.GetComponent<KeysCanvas>().keysTotal >= keysMinimo)
            //     {
            //         audioSource.PlayOneShot(puertaAuido);
            //         //ejecutar aniamcion "door"
            //         puertaAnim.Play("door");
            //     }
            //     else
            //     {
            //         Debug.Log("Te faltan llaves por conseguir.");
            //     }
            // }
            // else if (evaluarPregunta)
            // {
            //     panelPregunta.SetActive(true);
            // }
            else
            {
                audioSource.PlayOneShot(puertaAuido);
                //ejecutar aniamcion "door"
                puertaAnim.Play("door");

            }
        }
    }
    public void Destruir()
    {
        Destroy(gameObject);

    }

    public void RespuestaCorrecta()
    {
        audioSource.PlayOneShot(puertaAuido);
        //ejecutar aniamcion "door"
        puertaAnim.Play("door");

    }



}
