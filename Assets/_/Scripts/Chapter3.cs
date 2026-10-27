using UnityEngine;
using UnityEngine.SceneManagement;

public class Niveau3 : MonoBehaviour
{
    public string nomDeLaScene = "Niveau_3";

    public void ChangeLaScene()
    {
        SceneManager.LoadScene(nomDeLaScene);
    }
}