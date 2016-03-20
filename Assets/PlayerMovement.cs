using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {
	[SerializeField]
	private Rigidbody2D rigidBody;
	private float
		spriteRotation;
	public float 
		direction,
		speed,
		jumpForce;
	
	void Update()
	{
		direction = Input.GetAxisRaw("Horizontal");
		if(Input.GetKeyDown(KeyCode.Space))
		{
			Jump();
		}
		Move ();
	
	}

	void Jump()
	{
		rigidBody.velocity = Vector2.up * jumpForce;

	}
	
	void Move()
	{
		rigidBody.velocity = new Vector2(direction* speed, rigidBody.velocity.y) ;

		if(direction == 1 || direction == -1)
		{
			spriteRotation = Mathf.Rad2Deg* Mathf.Acos(direction);
			transform.eulerAngles = new Vector2(0,spriteRotation);
		}
		else
		{
			direction = Mathf.Cos(spriteRotation*Mathf.Deg2Rad);
		}

	}


}
