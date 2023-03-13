using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;

public class script_F_Note : MonoBehaviour
{
    public AudioSource F_Note;

    private void OnMouseDown()
    {
        {
            F_Note.Play();
            Console.Write("Note F ON");
        }
    }
}
