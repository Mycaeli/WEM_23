using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;

public class script_D_Note : MonoBehaviour
{
    public AudioSource D_Note;

    private void OnMouseDown()
    {
        {
            D_Note.Play();
            Console.Write("Note D ON");
        }
    }
}
