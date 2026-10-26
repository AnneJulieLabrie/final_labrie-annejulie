using UnityEngine;
using UnityEngine.SceneManagement;

public class Accueil : MonoBehaviour
{
    public string nomDeLaScene = "Accueil"; // Nom exact ☝️

    public void ChangeLaScene()
    {
        SceneManager.LoadScene(nomDeLaScene);
    }
}