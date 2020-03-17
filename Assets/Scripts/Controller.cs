using UnityEngine;

public class Controller : MonoBehaviour {

    private Vector2 _input;
    public new GameObject camera;
    public Sprite[] balloon;
	//public GameObject[] balloon;

    public float inputForce;
    public float xMin, xMax, yMin, yMax;

    public AudioSource bounce;
    
    void Start()
    {
		transform.position = new Vector2 (0, 0);
		gameObject.GetComponent<SpriteRenderer>().sprite = balloon[Random.Range(0, balloon.Length)];
    }

    void FixedUpdate () 
    {
        _input = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        GetComponent<Rigidbody2D>().AddForce(_input * inputForce);

        //GetComponent<Rigidbody2D>().rotation = Mathf.Lerp(GetComponent<Rigidbody2D>().rotation, -GetComponent<Rigidbody2D>().velocity.magnitude * 7f * (float)Input.GetAxis("Horizontal"), Time.deltaTime * 15f);

        GetComponent<Rigidbody2D>().position = new Vector3(
            Mathf.Clamp(GetComponent<Rigidbody2D>().position.x, xMin, xMax),
            Mathf.Clamp(GetComponent<Rigidbody2D>().position.y, camera.transform.position.y + yMin, camera.transform.position.y + yMax),
            0);
	}

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("ledge"))
        {
            bounce.Play();
        }
    }
}

