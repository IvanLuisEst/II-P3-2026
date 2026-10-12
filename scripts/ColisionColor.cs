using UnityEngine;

public class ColisionColor : MonoBehaviour
{

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log(gameObject.name + " ha chocado con: " + collision.gameObject.name);
        Color nuevoColor = new Color(
            Random.Range(0.0f, 1.0f),
            Random.Range(0.0f, 1.0f),
            Random.Range(0.0f, 1.0f)
        );
        GetComponent<Renderer>().material.color = nuevoColor;
    }
}
