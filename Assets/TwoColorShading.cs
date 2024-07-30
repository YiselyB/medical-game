using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TwoColorShading : MonoBehaviour
{
    public Material tileMaterial; 
    private MaterialPropertyBlock propBlock;

    void Start()
    {
        propBlock = new MaterialPropertyBlock();

        // Convert hex string to Color
        Color color;
        if (ColorUtility.TryParseHtmlString("#DF6396", out color))
        {
            propBlock.SetColor("_Color", color);

            // Apply the property block to the renderer of the tile
            Renderer renderer = GetComponent<Renderer>();
            renderer.SetPropertyBlock(propBlock);
        }
        else
        {
            Debug.LogError("Failed to parse color");
        }
    }
}