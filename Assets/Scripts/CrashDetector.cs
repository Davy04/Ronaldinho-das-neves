using UnityEngine;

public class CrashDetector : SceneReloader
{
    [SerializeField] private Collider2D headCollider;
    [SerializeField] private string sceneName = "Level1";
    [SerializeField] private float reloadTime = 1f;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.otherCollider == headCollider &&
            collision.collider.CompareTag("Ground"))
        {
            StartCoroutine(ReloadAfterDelay(sceneName, reloadTime));
        }
    }
}