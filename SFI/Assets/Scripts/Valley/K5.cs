using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class K5 : MonoBehaviour
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
            yield return new WaitForSeconds(7.2f);

            meshRenderer.material.color = Color.black;
            yield return new WaitForSeconds(0.2f);

            meshRenderer.material.color = Color.black;
            yield return new WaitForSeconds(0.2f);

            meshRenderer.material.color = Color.black;
            yield return new WaitForSeconds(0.4f);

            meshRenderer.material.color = originalColor;
            yield return new WaitForSeconds(0.4f);

        }
    }
}
