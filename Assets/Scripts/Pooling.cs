using UnityEngine;

public class Pooling : MonoBehaviour {

	public GameObject otherPref;
	public Vector3 newPos;

	void OnTriggerEnter2D(Collider2D other)
	{
        if (other.gameObject.tag == "MainCamera") 
		{
            otherPref.transform.position = new Vector3(0, otherPref.transform.position.y + newPos.y, 0);
			otherPref.transform.position += newPos;
		}
	}
}
