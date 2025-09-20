using Unity.VisualScripting;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    [SerializeField] bool hasPackage;
    [SerializeField] float delay = 0.3f;
    void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.CompareTag("Package") && !hasPackage)
        {
            Debug.Log("Picked up package!");
            hasPackage = true;
            GetComponent<ParticleSystem>().Play();
            Destroy(collision.gameObject, delay);

        }
        else if (collision.CompareTag("Customer") && hasPackage)
        {
            Debug.Log("Delivered package!");
            hasPackage = false;
            GetComponent<ParticleSystem>().Stop();
        }
    }
}
