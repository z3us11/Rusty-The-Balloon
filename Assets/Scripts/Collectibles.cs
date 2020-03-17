using UnityEngine;
using UnityEngine.SceneManagement;

public class Collectibles : MonoBehaviour {

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.transform.tag == "brick")
        {
            Destroy(this.gameObject);

            GameObject balloon = GameObject.Find("Balloon");
            HUDScript score = balloon.GetComponent<HUDScript>();

            score.StoreHighscore(score.score, score.highScore);

            SceneManager.LoadScene(2);
        }
        //if (other.transform.tag == "coin")
        //{
        //    Destroy(other.gameObject);
        //}

        //if (other.transform.tag == "powerUps")
        //{
        //    Destroy(other.gameObject);
        //    //Instantiate("Balloon", transform.position, Quaternion.identity);
        //}
    }
}
