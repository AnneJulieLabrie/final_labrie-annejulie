using UnityEngine;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class Quit : MonoBehaviour
{
    void Awake()
    {
        if (Application.platform == RuntimePlatform.WebGLPlayer)
            gameObject.SetActive(false);
    }

    public void Quitter()
    {
#if UNITY_EDITOR
        EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }
}