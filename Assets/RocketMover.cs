using UnityEngine;
using System.Collections;

public class RocketMover : MonoBehaviour
{
	public static float RocketPosition = 2;

	// Use this for initialization
	void Start ()
	{
		RocketPosition = 2;
	}

	void MoveLeft ()
	{
		//if ( !Mathf.Approximately ( RocketPosition, transform.position.x ) )
		//	return;
		if ( !Mathf.Approximately ( RocketPosition, 2 + -0.25f ) )
			RocketPosition -= 0.25f;
	}

	void MoveRight ()
	{
		//if ( !Mathf.Approximately ( RocketPosition, transform.position.x ) )
		//	return;
		if ( !Mathf.Approximately ( RocketPosition, 2 + 0.25f) )
			RocketPosition += 0.25f;
	}
	
	void Update ()
	{
		if ( RocketPosition > transform.position.x )
			transform.Translate ( 0.05f, 0.0f, 0.0f );
		if ( RocketPosition < transform.position.x )
			transform.Translate ( -0.05f, 0.0f, 0.0f );

		if ( Input.GetMouseButtonDown ( 0 ) )
			MoveLeft ();
		else if ( Input.GetMouseButtonDown ( 1 ) )
			MoveRight ();

		try
		{
			Touch touch = Input.GetTouch ( 0 );
			if ( touch.phase == TouchPhase.Began )
			{

			}
		}
		catch { }
	}
}
