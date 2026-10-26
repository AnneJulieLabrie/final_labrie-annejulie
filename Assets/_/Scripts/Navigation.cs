using UnityEngine;
using UnityEngine.SceneManagement;

public class Navigation : MonoBehaviour
{
    public string nomDeLaScene = "Navigation"; // Nom exact ☝️

    public void ChangeLaScene()
    {
        SceneManager.LoadScene(nomDeLaScene);
    }
}