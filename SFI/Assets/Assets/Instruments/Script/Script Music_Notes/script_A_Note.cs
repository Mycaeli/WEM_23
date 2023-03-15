using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;

public class script_A_Note : MonoBehaviour
{
    public AudioSource A_Note;

    private void OnMouseDown()
    {
        {
            A_Note.Play();
            Console.Write("Note A ON");
        }
    }
}
