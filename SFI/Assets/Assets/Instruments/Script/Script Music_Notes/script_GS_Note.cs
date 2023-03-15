using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;

public class script_GS_Note : MonoBehaviour
{
    public AudioSource GS_Note;

    private void OnMouseDown()
    {
        {
            GS_Note.Play();
            Console.Write("Note GS ON");
        }
    }
}
