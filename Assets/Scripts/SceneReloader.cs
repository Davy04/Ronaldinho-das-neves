using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public abstract class SceneReloader : MonoBehaviour
{
    protected IEnumerator ReloadAfterDelay(string sceneName, float delay)
    {
        yield return new WaitForSeconds(delay);
        SceneManager.LoadScene(sceneName);
    }
}