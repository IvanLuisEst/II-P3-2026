using UnityEngine;

public class colisionRecolectable : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("El jugador a recogido el recolectable.");
    }
}
