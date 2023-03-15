using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;

public class script_D1_Note : MonoBehaviour
{
    public AudioSource D1_Note;

    private void OnMouseDown()
    {
        {
            D1_Note.Play();
            Console.Write("Note D1 ON");
        }
    }
}
