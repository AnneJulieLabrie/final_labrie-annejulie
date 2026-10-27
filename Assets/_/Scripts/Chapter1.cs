using UnityEngine;
using UnityEngine.SceneManagement;

public class Niveau1 : MonoBehaviour
{
    public string nomDeLaScene = "Niveau_1";

    public void ChangeLaScene()
    {
        SceneManager.LoadScene(nomDeLaScene);
    }
}