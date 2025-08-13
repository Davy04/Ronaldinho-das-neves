using UnityEngine;

public class FinishLine : SceneReloader
{
    [SerializeField] private string sceneName = "Level1";
    [SerializeField] private float reloadTime = 2f;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            StartCoroutine(ReloadAfterDelay(sceneName, reloadTime));
        }
    }
}