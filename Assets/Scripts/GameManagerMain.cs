using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManagerMain : MonoBehaviour {

    public float RestartDelay = 2.0f;
    public GameObject CompleteLevelUI;

    bool gameHasEnded = false;

    public void CompleteLevel() {
        Debug.Log("Level Won!");
        CompleteLevelUI.SetActive(true);
    }

    public void GameOver() {

        if (gameHasEnded) return;
        Debug.Log("Game Over!");
        gameHasEnded = true;
        Invoke("Restart", RestartDelay);
    }

    void Restart() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
