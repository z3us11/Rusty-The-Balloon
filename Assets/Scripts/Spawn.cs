using UnityEngine;

public class Spawn : MonoBehaviour {
	
	public float delay, minDelay;
    public float spawnPoint, xMin, xMax;
    public new GameObject[] gameObject;
	public new GameObject camera;

    // Use this for initialization
	void Start () {
		Invoke("SpawnFunc", minDelay);
	}
	
	void SpawnFunc () {
        Instantiate(gameObject[Random.Range(0, gameObject.Length)], new Vector2(Random.Range(xMin, xMax), camera.transform.position.y + spawnPoint), Quaternion.identity);
		Invoke("SpawnFunc", Random.Range(minDelay, delay));
	}
}
