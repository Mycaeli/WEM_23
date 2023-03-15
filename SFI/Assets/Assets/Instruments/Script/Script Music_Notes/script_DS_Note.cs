using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;

public class script_DS_Note : MonoBehaviour
{
    public AudioSource DS_Note;

    private void OnMouseDown()
    {
        {
            DS_Note.Play();
            Console.Write("Note DS ON");
        }
    }
}
