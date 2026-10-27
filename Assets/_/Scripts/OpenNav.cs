using UnityEngine;
using UnityEngine.SceneManagement;

public class OpenNav : MonoBehaviour
{
    public string nomDeLaScene = "Chapters";

    public void ChangeLaScene()
    {
        SceneManager.LoadScene(nomDeLaScene);
    }
}