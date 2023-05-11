using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class K3 : MonoBehaviour
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

            for (int d = 0; d < 6; d++)
            {
                meshRenderer.material.color = Color.black;
                yield return new WaitForSeconds(0.5f);

                meshRenderer.material.color = originalColor;
                yield return new WaitForSeconds(0.2f);

                meshRenderer.material.color = Color.black;
                yield return new WaitForSeconds(0.5f);
            }



            meshRenderer.material.color = Color.black;
            yield return new WaitForSeconds(0.2f);

            meshRenderer.material.color = Color.black;
            yield return new WaitForSeconds(0.2f);

            meshRenderer.material.color = originalColor;
            yield return new WaitForSeconds(0.2f);

            meshRenderer.material.color = Color.black;
            yield return new WaitForSeconds(0.4f);

        }
    }
}