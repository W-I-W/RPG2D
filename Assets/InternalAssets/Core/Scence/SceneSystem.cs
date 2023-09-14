
using TMPro;

using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSystem : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI m_TextFPS;

    private void Start()
    {
        Application.targetFrameRate = 60;
    }

    private void Update()
    {
        m_TextFPS.text = "FPS: "+(1f/Time.deltaTime).ToString("00");
    }

    public void LoadScene(int index)
    {
        SceneManager.LoadSceneAsync(index);
    }
}
