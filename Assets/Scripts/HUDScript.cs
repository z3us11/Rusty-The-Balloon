using UnityEngine;
using UnityEngine.UI;

public class HUDScript : MonoBehaviour {
	
	public CameraFollow script;
	public Spawn ledges, brick;
	public float score, speed_inc, highScore;
	public Text scoreText, hiScoreText;
	public Rect rect;

	private int n = 1;
	// Use this for initialization
	void Start () {
		score = 0;
        highScore = PlayerPrefs.GetInt("highscore");
    }
	
	// Update is called once per frame
	void Update () {
		score += Time.deltaTime * 10;
		scoreText.text = "Score:" + (int)score;
        hiScoreText.text = "HiScore: " + (int)highScore;

		speed_inc += Time.deltaTime * 10;
		if (speed_inc >= 500*n)
		{
			n++;
			script.upSpeed.y += 0.2f;
			ledges.minDelay -= 0.1f;
			ledges.delay -= 0.5f;
			brick.delay -= 0.5f;
			brick.spawnPoint += 1f;
			speed_inc = 0;
		}

        if (score >= highScore)
        {
            highScore = score;
        }
	}

    public void StoreHighscore(float score, float newHighscore)
    {
        PlayerPrefs.SetInt("score", (int)score);
        int oldHighscore = PlayerPrefs.GetInt("highscore");
        if (newHighscore > oldHighscore)
            PlayerPrefs.SetInt("highscore", (int)newHighscore);
    }
}
