using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;

public class script_AS_Note : MonoBehaviour
{
    public AudioSource AS_Note;

    private void OnMouseDown()
    {
        {
            AS_Note.Play();
            Console.Write("Note AS ON");
        }
    }
}
