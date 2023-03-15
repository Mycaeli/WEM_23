using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;

public class script_FS_Note : MonoBehaviour
{
    public AudioSource FS_Note;

    private void OnMouseDown()
    {
        {
            FS_Note.Play();
            Console.Write("Note FS ON");
        }
    }
}
