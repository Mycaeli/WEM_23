using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;

public class script_CS_Note : MonoBehaviour
{
    public AudioSource CS_Note;

    private void OnMouseDown()
    {
        {
            CS_Note.Play();
            Console.Write("Note CS ON");
        }
    }
}
