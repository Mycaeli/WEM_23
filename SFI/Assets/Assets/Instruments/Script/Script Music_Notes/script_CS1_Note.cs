using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;

public class script_CS1_Note : MonoBehaviour
{
    public AudioSource CS1_Note;

    private void OnMouseDown()
    {
        {
            CS1_Note.Play();
            Console.Write("Note CS1 ON");
        }
    }
}
