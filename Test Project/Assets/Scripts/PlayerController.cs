using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public float speed;
	public Text countText;
	public Text winText;

	private Rigidbody rb;
	private int count;

	void Start()
	{
		rb = GetComponent<Rigidbody> ();
		count = 0;
		SetCountText ();
		winText.text = "";
	}

	void FixedUpdate ()
	{
		float moveHorizontal = 5 * Cardboard.SDK.HeadPose.Orientation[1];
		float moveVertical = -5 * Cardboard.SDK.HeadPose.Orientation[0];

		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);

		rb.AddForce (movement * speed);

		// print (Input.GetAxis ("Horizontal"));
		// print (Input.GetAxis ("Vertical"));

		// print (Cardboard.SDK.HeadPose.Orientation[0]);
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