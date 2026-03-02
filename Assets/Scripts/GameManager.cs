using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEditor.SearchService;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gameHasEnded = false;

    public float restartDelay = 1f;

    public GameObject completeLevelUI;
    public GameObject completeLevelText;

    public void CompleteLevel()
    {
        completeLevelUI.SetActive(true);
        completeLevelText.SetActive(true);

    }
    public void gameOver()
    {

        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("Wow. You suck.");
            Invoke("Restart", restartDelay);

        }

    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

   
}
