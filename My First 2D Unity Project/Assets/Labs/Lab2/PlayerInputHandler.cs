//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class PlayerInputHandler : MonoBehaviour {
//	public float horizontalSpeed;

//	private Animator animator;
//	private bool facingRight; 

//	void Start () {
//        // assign the component to a name that's easy to use in this object
//        animator = GetComponent<Animator>();
//		facingRight = true;
//	}
	
//	void Update () {
        
//		horizontalSpeed = Input.GetAxis ("Horizontal");

//        // checks to see if it's facing the right way
//        // if running to the right but not facing right
//        // or if running to the left and not facing left
//        // then flip them 
//		if (horizontalSpeed > 0 && !facingRight || horizontalSpeed < 0 && facingRight)
//		{
//			facingRight = !facingRight;

//			Vector3 temp = transform.localScale;
//			temp.x *= -1;
//			transform.localScale = temp;
//		}

//        // compare to the abs value
//		horizontalSpeed = Mathf.Abs(horizontalSpeed);
        
//		// this test helps for numerical instability--sometimes a float is 0, but won't
//		// be 0 (especially on an input device) and instead will be super close to zero
//		if (horizontalSpeed > .0001f)
//			animator.SetFloat("Horizontal Speed", horizontalSpeed);
//		else
//			animator.SetFloat("Horizontal Speed", 0.0f);

//		print(horizontalSpeed);
//	}
//}
