using UnityEngine;

public class Swipe : MonoBehaviour 
{
	
	public float swipeSpeed;
	public float minSwipeDistY;
	public float minSwipeDistX;

    public AudioSource swoosh;
	
	private Vector2 startPos;
	
	void Update()
	{
		//#if UNITY_ANDROID
		if (Input.touchCount > 0) 
			
		{
			Touch touch = Input.touches[0];
	
			switch (touch.phase) 
			{			
			case TouchPhase.Began:	
				startPos = touch.position;
				break;
				
			case TouchPhase.Ended:
				float swipeDistVertical = (new Vector3(0, touch.position.y, 0) - new Vector3(0, startPos.y, 0)).magnitude;
				if (swipeDistVertical > minSwipeDistY) 
				{
					float swipeValue = touch.position.y - startPos.y;	
					if (swipeValue > 0){//up swipe
						GetComponent<Rigidbody2D>().AddForce(new Vector2(0, swipeSpeed * swipeValue));
                            swoosh.Play();
                        }

					else if (swipeValue < 0){//down swipe
						GetComponent<Rigidbody2D>().AddForce(new Vector2(0, swipeSpeed * swipeValue));
                            swoosh.Play();
                        }
				}
		
				float swipeDistHorizontal = (new Vector3(touch.position.x,0, 0) - new Vector3(startPos.x, 0, 0)).magnitude;
				if (swipeDistHorizontal > minSwipeDistX) 			
				{
					float swipeValue = touch.position.x - startPos.x;	
					if (swipeValue > 0){//right swipe
						GetComponent<Rigidbody2D>().AddForce(new Vector2(swipeSpeed * swipeValue, 0));
                        swoosh.Play();
					}

					else if (swipeValue < 0){//left swipe
						GetComponent<Rigidbody2D>().AddForce(new Vector2(swipeSpeed * swipeValue, 0));
                        swoosh.Play();
					}

                        //GetComponent<Rigidbody2D>().rotation = Mathf.Lerp(GetComponent<Rigidbody2D>().rotation, -GetComponent<Rigidbody2D>().velocity.magnitude * swipeValue * 0.5f, Time.deltaTime * 5f);
                    }
				break;
			}
		}
	}
}
