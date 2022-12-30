using UnityEngine;
using UnityEngine.SceneManagement;

public class SpecialScene : MonoBehaviour
{
    public string sceneNameToLoad;
    
   private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            SceneManager.LoadScene(sceneNameToLoad);
        }
    }
}
