using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class B4 : MonoBehaviour
{
    private MeshRenderer meshRenderer;
    private Color originalColor;

    private void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
        originalColor = meshRenderer.material.color;

        StartCoroutine(BlinkLoop());
    }

    private IEnumerator BlinkLoop()
    {
        while (true)
        {

         
            meshRenderer.material.color = Color.black;
            yield return new WaitForSeconds(4.8f);

        }
    }
}
