using UnityEngine;

public class movimientoPersonaje : MonoBehaviour
{
    public float speed = 5f;

    private Rigidbody rb;
    private float horizontal;
    private float vertical;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");
    }

    void FixedUpdate()
    {
        Vector3 movimiento = new Vector3(horizontal, 0f, vertical);

        rb.MovePosition(transform.position + movimiento * Time.fixedDeltaTime * speed);
    }
}
