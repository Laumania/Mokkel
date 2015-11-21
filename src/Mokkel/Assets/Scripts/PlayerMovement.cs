using UnityEngine;
using System.Collections;
using UnityStandardAssets.CrossPlatformInput;

public class PlayerMovement : MonoBehaviour 
{
	public float Speed = 50f;
	private Rigidbody2D _body;

	// Use this for initialization
	void Start () 
	{
		_body = this.GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () 
	{
		var horizontalMovement = CrossPlatformInputManager.GetAxis("Horizontal");

		if(horizontalMovement != 0f)
			this.transform.localScale = new Vector3 (-horizontalMovement,1f,1f);

		_body.AddForce (new Vector2 (horizontalMovement * Speed * Time.deltaTime, 0f), ForceMode2D.Impulse);
	}
}
