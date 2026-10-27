using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    public string nomDeLaScene = "Niveau_1";

    public void ChangeLaScene()
    {
        SceneManager.LoadScene(nomDeLaScene);
    }
}