using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;

public class script_E_Note : MonoBehaviour
{
    public AudioSource E_Note;

    private void OnMouseDown()
    {
        {
            E_Note.Play();
            Console.Write("Note E ON");
        }
    }
}
