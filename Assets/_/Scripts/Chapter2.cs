using UnityEngine;
using UnityEngine.SceneManagement;

public class Niveau2 : MonoBehaviour
{
    public string nomDeLaScene = "Niveau_2";

    public void ChangeLaScene()
    {
        SceneManager.LoadScene(nomDeLaScene);
    }
}