
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSystem : MonoBehaviour
{
    public void LoadScene(int index)
    {
        SceneManager.LoadSceneAsync(index);
    }
}
