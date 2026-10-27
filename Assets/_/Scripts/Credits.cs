using UnityEngine;
using UnityEngine.SceneManagement;

public class OpenCredits : MonoBehaviour
{
    public string nomDeLaScene = "Credits";

    public void ChangeLaScene()
    {
        SceneManager.LoadScene(nomDeLaScene);
    }
}