using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;

public class script_B_Note : MonoBehaviour
{
    public AudioSource B_Note;

    private void OnMouseDown()
    {
        {
            B_Note.Play();
            Console.Write("Note B ON");
        }
    }
}
