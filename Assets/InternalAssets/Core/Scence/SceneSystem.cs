
using TMPro;

using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSystem : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI m_TextFPS;


    private float m_FPS;
    private void Start()
    {
        m_FPS = 60;
        Application.targetFrameRate = 60;
    }

    private void Update()
    {
        if ((m_TextFPS != null))
        {
            m_FPS = Mathf.MoveTowards(m_FPS, 1f / Time.deltaTime, Time.deltaTime);
            m_TextFPS.text = "FPS: " + (m_FPS).ToString("00");
        }
    }

    public void LoadScene(int index)
    {
        SceneManager.LoadSceneAsync(index);
    }
}
