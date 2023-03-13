using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;

public class script_DS1_Note : MonoBehaviour
{
    public AudioSource DS1_Note;

    private void OnMouseDown()
    {
        {
            DS1_Note.Play();
            Console.Write("Note DS1 ON");
        }
    }
}
