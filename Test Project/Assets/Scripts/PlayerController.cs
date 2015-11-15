using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public float speed = 0f;
	public Text countText;
	public Text winText;

	private Rigidbody rb;
	private int count;
	private int moveToggle = 0;
	private float moveHorizontal;

	private float x;
	private float z;
	private float angle;

	Vector3 movement = new Vector3(0f, 0f, 0f);

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
			speed = 0.1f;

			if (Cardboard.SDK.HeadPose.Orientation[1] >= -0.05 && Cardboard.SDK.HeadPose.Orientation[1] < 0.05){
				angle = 0.0f * Mathf.PI;
				z = Mathf.Cos (angle);
				x = 1.0f - z;
				
				movement = new Vector3 (x, 0.0f, -z);
			}

			else if (Cardboard.SDK.HeadPose.Orientation[1] >= 0.05 && Cardboard.SDK.HeadPose.Orientation[1] < 0.15){
				angle = 0.1f * Mathf.PI;
				z = Mathf.Cos (angle);
				x = 1.0f - z;

				movement = new Vector3 (-x, 0.0f, -z);
			}

			else if (Cardboard.SDK.HeadPose.Orientation[1] >= 0.15 && Cardboard.SDK.HeadPose.Orientation[1] < 0.25){
				angle = 0.2f * Mathf.PI;
				z = Mathf.Cos (angle);
				x = 1.0f - z;
				
				movement = new Vector3 (-x, 0.0f, -z);
			}

			else if (Cardboard.SDK.HeadPose.Orientation[1] >= 0.25 && Cardboard.SDK.HeadPose.Orientation[1] < 0.35){
				angle = 0.3f * Mathf.PI;
				z = Mathf.Cos (angle);
				x = 1.0f - z;
				
				movement = new Vector3 (-x, 0.0f, -z);
			}

			else if (Cardboard.SDK.HeadPose.Orientation[1] >= 0.35 && Cardboard.SDK.HeadPose.Orientation[1] < 0.45){
				angle = 0.4f * Mathf.PI;
				z = Mathf.Cos (angle);
				x = 1.0f - z;
				
				movement = new Vector3 (-x, 0.0f, -z);
			}

			else if (Cardboard.SDK.HeadPose.Orientation[1] >= 0.45 && Cardboard.SDK.HeadPose.Orientation[1] < 0.55){
				angle = 0.5f * Mathf.PI;
				z = Mathf.Cos (angle);
				x = 1.0f - z;
				
				movement = new Vector3 (-x, 0.0f, -z);
			}

			else if (Cardboard.SDK.HeadPose.Orientation[1] >= 0.55 && Cardboard.SDK.HeadPose.Orientation[1] < 0.65){
				angle = 0.6f * Mathf.PI;
				z = Mathf.Cos (angle);
				x = 1.0f - z;
				
				movement = new Vector3 (-x, 0.0f, -z);
			}

			else if (Cardboard.SDK.HeadPose.Orientation[1] >= 0.65 && Cardboard.SDK.HeadPose.Orientation[1] < 0.75){
				angle = 0.7f * Mathf.PI;
				z = Mathf.Cos (angle);
				x = 1.0f - z;
				
				movement = new Vector3 (-x, 0.0f, -z);
			}

			else if (Cardboard.SDK.HeadPose.Orientation[1] >= 0.75 && Cardboard.SDK.HeadPose.Orientation[1] < 0.85){
				angle = 0.8f * Mathf.PI;
				z = Mathf.Cos (angle);
				x = 1.0f - z;
				
				movement = new Vector3 (-x, 0.0f, -z);
			}

			else if (Cardboard.SDK.HeadPose.Orientation[1] >= 0.85 && Cardboard.SDK.HeadPose.Orientation[1] < 0.95){
				angle = 0.9f * Mathf.PI;
				z = Mathf.Cos (angle);
				x = 1.0f - z;
				
				movement = new Vector3 (-x, 0.0f, -z);
			}

			else if (Cardboard.SDK.HeadPose.Orientation[1] >= 0.95 && Cardboard.SDK.HeadPose.Orientation[1] < 1.0){
				angle = 1.0f * Mathf.PI;
				z = Mathf.Cos (angle);
				x = 1.0f - z;
				
				movement = new Vector3 (x, 0.0f, -z);
			}

			else if (Cardboard.SDK.HeadPose.Orientation[1] >= -0.15 && Cardboard.SDK.HeadPose.Orientation[1] < -0.05){
				angle = -0.1f * Mathf.PI;
				z = Mathf.Cos (angle);
				x = 1.0f - z;
				
				movement = new Vector3 (x, 0.0f, -z);
			}

			else if (Cardboard.SDK.HeadPose.Orientation[1] >= -0.25 && Cardboard.SDK.HeadPose.Orientation[1] < -0.15){
				angle = -0.2f * Mathf.PI;
				z = Mathf.Cos (angle);
				x = 1.0f - z;
				
				movement = new Vector3 (x, 0.0f, -z);
			}

			else if (Cardboard.SDK.HeadPose.Orientation[1] >= -0.35 && Cardboard.SDK.HeadPose.Orientation[1] < -0.25){
				angle = -0.3f * Mathf.PI;
				z = Mathf.Cos (angle);
				x = 1.0f - z;
				
				movement = new Vector3 (x, 0.0f, -z);
			}

			else if (Cardboard.SDK.HeadPose.Orientation[1] >= -0.45 && Cardboard.SDK.HeadPose.Orientation[1] < -0.35){
				angle = -0.4f * Mathf.PI;
				z = Mathf.Cos (angle);
				x = 1.0f - z;
				
				movement = new Vector3 (x, 0.0f, -z);
			}

			else if (Cardboard.SDK.HeadPose.Orientation[1] >= -0.55 && Cardboard.SDK.HeadPose.Orientation[1] < -0.45){
				angle = -0.5f * Mathf.PI;
				z = Mathf.Cos (angle);
				x = 1.0f - z;
				
				movement = new Vector3 (x, 0.0f, -z);
			}

			else if (Cardboard.SDK.HeadPose.Orientation[1] >= -0.65 && Cardboard.SDK.HeadPose.Orientation[1] < -0.55){
				angle = -0.6f * Mathf.PI;
				z = Mathf.Cos (angle);
				x = 1.0f - z;
				
				movement = new Vector3 (x, 0.0f, -z);
			}

			else if (Cardboard.SDK.HeadPose.Orientation[1] >= -0.75 && Cardboard.SDK.HeadPose.Orientation[1] < -0.65){
				angle = -0.7f * Mathf.PI;
				z = Mathf.Cos (angle);
				x = 1.0f - z;
				
				movement = new Vector3 (x, 0.0f, -z);
			}

			else if (Cardboard.SDK.HeadPose.Orientation[1] >= -0.85 && Cardboard.SDK.HeadPose.Orientation[1] < -0.75){
				angle = -0.8f * Mathf.PI;
				z = Mathf.Cos (angle);
				x = 1.0f - z;
				
				movement = new Vector3 (x, 0.0f, -z);
			}

			else if (Cardboard.SDK.HeadPose.Orientation[1] >= -0.95 && Cardboard.SDK.HeadPose.Orientation[1] < -0.85){
				angle = -0.9f * Mathf.PI;
				z = Mathf.Cos (angle);
				x = 1.0f - z;
				
				movement = new Vector3 (x, 0.0f, -z);
			}

			else if (Cardboard.SDK.HeadPose.Orientation[1] >= -1.00 && Cardboard.SDK.HeadPose.Orientation[1] < -0.95){
				angle = -1f * Mathf.PI;
				z = Mathf.Cos (angle);
				x = 1.0f - z;
				
				movement = new Vector3 (x, 0.0f, -z);
			}

			rb.AddForce (movement * speed);
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