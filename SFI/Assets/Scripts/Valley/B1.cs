using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class B1 : MonoBehaviour
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

                meshRenderer.material.color = originalColor;
                yield return new WaitForSeconds(0.5f);

                meshRenderer.material.color = Color.black;
                yield return new WaitForSeconds(1.0f);
            

        }
    }
}
