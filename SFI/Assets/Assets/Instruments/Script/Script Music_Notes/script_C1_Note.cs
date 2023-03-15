using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;

public class script_C1_Note : MonoBehaviour
{
    public AudioSource C1_Note;

    private void OnMouseDown()
    {
        {
            C1_Note.Play();
            Console.Write("Note C1 ON");
        }
    }
}
