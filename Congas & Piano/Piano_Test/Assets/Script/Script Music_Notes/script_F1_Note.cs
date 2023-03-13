using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;

public class script_F1_Note : MonoBehaviour
{
    public AudioSource F1_Note;

    private void OnMouseDown()
    {
        {
            F1_Note.Play();
            Console.Write("Note F1 ON");
        }
    }
}
