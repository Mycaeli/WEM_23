using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;

public class script_G_Note : MonoBehaviour
{
    public AudioSource G_Note;

    private void OnMouseDown()
    {
        {
            G_Note.Play();
            Console.Write("Note G ON");
        }
    }
}
