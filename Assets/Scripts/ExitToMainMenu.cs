using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitToMainMenu : MonoBehaviour
{
    public void exitToMainMenu()
    {
        SceneManager.LoadScene(0);
    }
}
