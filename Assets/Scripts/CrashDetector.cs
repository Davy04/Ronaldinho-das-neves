using UnityEngine;

public class CrashDetector : MonoBehaviour
{
    public Collider2D headCollider; // arraste o collider da cabeça no Inspector

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.otherCollider == headCollider && 
            collision.collider.CompareTag("Ground"))
        {
            Debug.Log("Bateu com a cabeça!");
        }
    }
}