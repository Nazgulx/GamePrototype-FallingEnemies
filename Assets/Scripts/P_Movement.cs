using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P_Movement : MonoBehaviour
{	
	public float speed = 10f;
	public bool p_facingRight;
	Rigidbody2D rb;

	void Update () {
		rb = GetComponent<Rigidbody2D>();
		Vector2 input = new Vector2 (Input.GetAxisRaw ("Horizontal"), 0);
		Vector2 direction = input.normalized;
		Vector2 velocity = direction * speed;
		Vector3 moveAmount = velocity * Time.deltaTime;
		rb.AddForce(velocity);

	 if (moveAmount.x > 0 && !p_facingRight)
			Flip ();
		else if (moveAmount.x < 0 && p_facingRight)
			Flip ();

		//transform.position += moveAmount;
		//transform.Translate(moveAmount);
		
		
	}

	void Flip()
	{
		p_facingRight = !p_facingRight;
		transform.Rotate(0f, 180f, 0f);
	}
   
}
