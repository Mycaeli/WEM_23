using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;

public class script_E1_Note : MonoBehaviour
{
    public AudioSource E1_Note;

    private void OnMouseDown()
    {
        {
            E1_Note.Play();
            Console.Write("Note E1 ON");
        }
    }
}
