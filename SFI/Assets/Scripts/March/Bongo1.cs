using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bongo1 : MonoBehaviour
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
            yield return new WaitForSeconds(2.6f);

            meshRenderer.material.color = originalColor;
            yield return new WaitForSeconds(0.6f);

            


        }
    }
}