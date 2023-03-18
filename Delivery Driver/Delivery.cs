using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    bool hasPackage;
    [SerializeField] float delay = 0.5f;
    [SerializeField] Color32 hasPackageColor = new Color32(1, 1, 1, 1);
    [SerializeField] Color32 hasNotPackageColor = new Color32(1, 1, 1, 1);

    SpriteRenderer spriteRenderer;

    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
    void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("Ouch");
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Package" && !hasPackage)
        {
            Debug.Log("Package aquired");
            hasPackage = true;
            spriteRenderer.color = hasPackageColor;
            Destroy(other.gameObject, delay);
        }
        else if (other.tag == "Customer" && hasPackage)
        {
            Debug.Log("Package delivered");
            spriteRenderer.color = hasNotPackageColor;
            hasPackage = false;
        }
    }
}
