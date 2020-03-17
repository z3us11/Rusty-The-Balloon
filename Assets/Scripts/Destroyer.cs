using UnityEngine;
using UnityEngine.SceneManagement;

public class Destroyer : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D other)
    {
      if (other.gameObject.tag == "Player") {
			GameObject balloon = GameObject.Find("Balloon");
			HUDScript score = balloon.GetComponent<HUDScript>();

            score.StoreHighscore(score.score, score.highScore);

            SceneManager.LoadScene(2);
            //try
            //{
            //	string line;

            //	StreamReader theReader = new StreamReader("highscore.txt", Encoding.Default);
            //	using (theReader)
            //	{
            //		// While there's lines left in the text file, do this:
            //		do
            //		{
            //			line = theReader.ReadLine();
            //		}
            //		while (line != null);

            //	}
            //	theReader.Close();
            //	if(score.score > int.Parse(line))
            //	{
            //		 StreamWriter writer = new StreamWriter("highscore.txt");

            //		 writer.WriteLine(score.score);
            //	}
            //}
            //catch
            //{

            //}
            //Application.LoadLevel(0);
        }
			
	  if (other.gameObject.tag != "BackGround")
			Destroy(other.gameObject);
    }

}
