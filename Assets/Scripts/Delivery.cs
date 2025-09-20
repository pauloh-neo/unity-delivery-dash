using Unity.VisualScripting;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    bool hasPackage;
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Package"))
        {
            Debug.Log("Picked up package!");
            hasPackage = true;

        }
        else if (collision.CompareTag("Customer") && hasPackage)
        {
            Debug.Log("Delivered package!");
            hasPackage = false;
        }
    }
}
