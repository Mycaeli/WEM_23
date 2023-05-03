using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colors1 : MonoBehaviour
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
            for (int i = 0; i < 2; i++)
            {
                 meshRenderer.material.color = Color.black;
                 yield return new WaitForSeconds(0.8f);

                 meshRenderer.material.color = originalColor;
                 yield return new WaitForSeconds(1.5f);
            }

            meshRenderer.material.color = Color.black;
            yield return new WaitForSeconds(7.8f);

            meshRenderer.material.color = originalColor;
             yield return new WaitForSeconds(0.5f);
            
        }
    }
}