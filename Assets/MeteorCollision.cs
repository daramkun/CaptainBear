using UnityEngine;
using System.Collections;

public class MeteorCollision : MonoBehaviour
{
	public Object Particle;

	void Start ()
	{

	}

	protected virtual void IsCollisionTo ()
	{
		GameObject obj = Instantiate ( Particle ) as GameObject;
		obj.transform.Translate ( RocketMover.RocketPosition - 2, 0, 0 );

		GameOverChecker.IsGameOver = true;

		GameObject.DestroyObject ( this.gameObject );
	}

	// Update is called once per frame
	void Update ()
	{
		if ( transform.position.z >= -0.05f && transform.position.z <= 0.05f )
		{
			if ( Mathf.Abs ( transform.position.x - RocketMover.RocketPosition ) <= float.Epsilon )
				IsCollisionTo ();
		}
	}
}
