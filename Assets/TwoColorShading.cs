using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TwoColorShading : MonoBehaviour
{
    public Color hexagonColor = Color.white;
    public Color squareColor = Color.black;

    private Renderer[] renderers;

    void Start()
    {
        renderers = GetComponentsInChildren<Renderer>();
        ChangeColor(hexagonColor, squareColor);
    }

    void ChangeColor(Color hexagonColor, Color squareColor)
    {
        foreach (Renderer renderer in renderers)
        {
            foreach (Material material in renderer.materials)
            {
                if (material.name.Contains("HexagonMaterial"))
                {
                    material.color = hexagonColor;
                }
                else if (material.name.Contains("SquareMaterial"))
                {
                    material.color = squareColor;
                }
            }
        }
    }
}
