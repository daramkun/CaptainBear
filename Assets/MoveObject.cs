using UnityEngine;
using System.Collections;

public class MoveObject : MonoBehaviour
{
	float alpha;

	// Use this for initialization
	void Start ()
	{
		alpha = 0;
		this.renderer.material.color = new Color ( 0.3f, 0.3f, 0.3f, 0 );
	}

	// Update is called once per frame
	void Update ()
	{
		if ( GameOverChecker.IsGameOver ) return;

		if ( alpha < 1 )
		{
			alpha += 0.02f;
			if ( alpha >= 1 ) alpha = 1;
			this.renderer.material.color = new Color ( 0.3f, 0.3f, 0.3f, alpha );
		}
		else
			this.renderer.material.color = new Color ( 0.3f, 0.3f, 0.3f, 1.0f );
		
		transform.Rotate ( new Vector3 ( 0, 1, 0 ), 2 );
		transform.position += new Vector3 ( 0, 0, -0.01f * ( 3000.0f / ObjectCreator.Speed ) );
		
		if ( transform.position.z <= -1 )
			UnityEngine.Object.DestroyObject ( this.gameObject );
	}
}