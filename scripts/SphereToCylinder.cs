using UnityEngine;

public class SphereToCylinder : MonoBehaviour
{
    private Transform cubeTransform;
    private Transform cylinderTransform;
    private Renderer rendererCubo;
    private Material materialCube;
    private float speed = 5f;
    private bool materialCambiado = false;

    void Start()
    {
        GameObject cube = GameObject.FindWithTag("cube");
        cubeTransform = cube.transform;
        rendererCubo = cube.GetComponent<Renderer>();
        materialCube = Resources.Load<Material>("materialCube");
        GameObject cylinder = GameObject.FindWithTag("cylinder");
        cylinderTransform = cylinder.transform;
    }

    void Update()
    {
        Vector3 direction = cylinderTransform.position - transform.position;
        direction = direction.normalized;
        transform.Translate(direction * speed * Time.deltaTime);
        if (!materialCambiado && Vector3.Distance(transform.position, cubeTransform.position) < 1f)
        {
            rendererCubo.material = materialCube;
            materialCambiado = true;
        }

    }
}
