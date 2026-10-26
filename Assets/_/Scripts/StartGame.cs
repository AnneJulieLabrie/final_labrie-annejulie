using UnityEngine;
using UnityEngine.SceneManagement;

public class Start : MonoBehaviour
{
    public string nomDeLaScene = "Niveau_1"; // Nom exact ☝️

    public void ChangeLaScene()
    {
        SceneManager.LoadScene(nomDeLaScene);
    }
}