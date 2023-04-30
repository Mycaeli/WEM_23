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
    }

    private void Update()
    {
        float time = Time.time;
        if (time % 10 < 5)
        {
            meshRenderer.material.color = Color.red;
        }
        else
        {
            meshRenderer.material.color = originalColor;
        }
    }
}
