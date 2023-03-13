using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;

public class script_C_Note : MonoBehaviour
{
    public AudioSource C_Note;

    private void OnMouseDown() 
    {
        {
            C_Note.Play();
            Console.Write("Note C ON");
        }
    }
}
