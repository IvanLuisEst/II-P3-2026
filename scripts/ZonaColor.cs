using UnityEngine;

public class ZonaColor : MonoBehaviour
{
    private Color colorOriginal;

    void OnTriggerEnter(Collider other)
    {
        colorOriginal = other.GetComponent<Renderer>().material.color;
        Color nuevoColor = new Color(
            Random.Range(0.0f, 1.0f),
            Random.Range(0.0f, 1.0f),
            Random.Range(0.0f, 1.0f)
        );
        other.GetComponent<Renderer>().material.color = nuevoColor;
    }

    void OnTriggerExit(Collider other)
    {
        other.GetComponent<Renderer>().material.color = colorOriginal;
    }
}
