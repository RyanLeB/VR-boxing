using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PunchingBag : MonoBehaviour
{
    public float forceMultiplier = 5f; // Adjust power of punches

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Hand"))
        {
            // Calculate direction of punch
            Vector3 punchDirection = (transform.position - other.transform.position).normalized;
            rb.AddForce(punchDirection * forceMultiplier, ForceMode.Impulse);
        }
    }
}
