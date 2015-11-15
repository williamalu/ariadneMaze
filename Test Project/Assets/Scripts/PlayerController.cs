using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public float speed = 0;
	public Text countText;
	public Text winText;

	private Rigidbody rb;
	private int count;
	private int moveToggle = 0;
	private float moveHorizontal;

	void Start()
	{
		rb = GetComponent<Rigidbody> ();
		count = 0;
		SetCountText ();
		winText.text = "";
	}

	void FixedUpdate ()
	{
		
		if (Cardboard.SDK.Triggered == true) {
			moveToggle++;
		}

		if (moveToggle % 2 != 0){
			// odd values will mean move forward
			// even numbers will mean stop
			speed = 0.5f;

			if (Cardboard.SDK.HeadPose.Orientation[1] >= 0){
				moveHorizontal = 3 * Cardboard.SDK.HeadPose.Orientation[1];
			} else if (Cardboard.SDK.HeadPose.Orientation[1] < 0){
				moveHorizontal = -3 * Cardboard.SDK.HeadPose.Orientation[1];
			}

			Vector3 movement = new Vector3 (moveHorizontal, 0.0f, -0.1f);

			rb.AddForce (movement * speed);

//			print (moveToggle);
			print (Cardboard.SDK.HeadPose.Orientation[1]);
//			print (movement);
		} else {
			GetComponent<Rigidbody>().velocity=Vector3.zero;
		}
	}

	void OnTriggerEnter(Collider other) {

		if (other.gameObject.CompareTag ("Pickup"))
		{
			other.gameObject.SetActive (false);
			count = count + 1;
			SetCountText ();
		}
	}

	void SetCountText ()
	{
		countText.text = "Count: " + count.ToString();
		if (count >= 8) 
		{
			winText.text = "You Win!";
		}
	}
}