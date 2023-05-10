using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Leap.Unity.Interaction;

using UnityEngine;

public class Boton : MonoBehaviour
{
    private bool manoTocandoBoton = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("mano"))
        {
            // La mano está tocando el botón
            manoTocandoBoton = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("mano"))
        {
            // La mano dejó de tocar el botón
            manoTocandoBoton = false;
        }
    }

    private void Update()
    {
        if (manoTocandoBoton)
        {
            DestroyNotas();
        }
    }

    private void DestroyNotas()
    {
        GameObject[] notas = GameObject.FindGameObjectsWithTag("nota");

        foreach (GameObject nota in notas)
        {
            Collider notaCollider = nota.GetComponent<Collider>();
            Collider botonCollider = GetComponent<Collider>();

            if (notaCollider.bounds.Intersects(botonCollider.bounds))
            {
                Destroy(nota);
            }
        }
    }
}
