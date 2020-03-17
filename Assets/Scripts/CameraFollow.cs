using UnityEngine;

public class CameraFollow : MonoBehaviour {

    public Vector3 upSpeed;
    // Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        transform.position += (upSpeed/10) ;
	}
}
