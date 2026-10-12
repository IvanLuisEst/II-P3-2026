using UnityEngine;

public class ZonaDamage : MonoBehaviour
{
    public int damage = 0;
    private int aumentoDamage = 10;

    void OnTriggerEnter(Collider other)
    {
        damage += aumentoDamage;
        Debug.Log("Daño actual: " + damage);
    }
}
