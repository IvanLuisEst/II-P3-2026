using UnityEngine;

public class LanzarObjeto : MonoBehaviour
{
    public float fuerza = 5f;
    private bool lanzar = false;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.X))
        {
            lanzar = true;
        }
    }

    void FixedUpdate()
    {
        if (lanzar)
        {
            GetComponent<Rigidbody>().AddForce(fuerza, fuerza, 0, ForceMode.Impulse);
            lanzar = false;
        }
    }
}
