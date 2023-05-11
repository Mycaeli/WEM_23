using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colors : MonoBehaviour
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
            yield return new WaitForSeconds(6.4f);

            for (int i = 0; i < 3; i++)
            {
                meshRenderer.material.color = Color.black;
                yield return new WaitForSeconds(0.2f);

                meshRenderer.material.color = originalColor;
                yield return new WaitForSeconds(0.6f);
            }

            meshRenderer.material.color = Color.black;
            yield return new WaitForSeconds(3.4f);

            meshRenderer.material.color = Color.black;
            yield return new WaitForSeconds(1.4f);
        }
    }
}
