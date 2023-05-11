using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class B2 : MonoBehaviour
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
            yield return new WaitForSeconds(0.6f);

            for (int d = 0; d < 2; d++)
            {

                meshRenderer.material.color = originalColor;
                yield return new WaitForSeconds(0.3f);

                meshRenderer.material.color = Color.black;
                yield return new WaitForSeconds(0.2f);
            }

            meshRenderer.material.color = Color.black;
            yield return new WaitForSeconds(1.4f);

            //4.8F
        }
    }
}