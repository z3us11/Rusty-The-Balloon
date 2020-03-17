using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOver : MonoBehaviour {

    public float score, hiScore;
    public Text scoreText, hiScoreText;

    void Start()
    {
        score = PlayerPrefs.GetInt("score");
        hiScore = PlayerPrefs.GetInt("highscore");

        scoreText.text = "Score: " + score;
        hiScoreText.text = "HiScore: " + hiScore;
    }

    public void OnClickPlayAgain()
    {
        SceneManager.LoadScene(1);
    }

    public void OnClickMainMenu()
    {
        SceneManager.LoadScene(0);
    }
}
