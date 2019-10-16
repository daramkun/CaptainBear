using UnityEngine;
using System.Collections;
using System;

public class ObjectCreator : MonoBehaviour
{
	public static int Speed;
	readonly float PositionUnit = 0.25f;
	TimeSpan lastTimeSpan, elapsedTimeSpan;

	public UnityEngine.Object Meteor, ItemSpeedDown, ItemSpeedUp, ItemShield, ItemReverse, ItemStar;

	// Use this for initialization
	void Start ()
	{
		Speed = 3000;
		lastTimeSpan = TimeSpan.FromMilliseconds ( Environment.TickCount - 2800 );
	}

	// Update is called once per frame
	void Update ()
	{
		if ( GameOverChecker.IsGameOver ) return;

		TimeSpan nowTimeSpan = TimeSpan.FromMilliseconds ( Environment.TickCount );
		elapsedTimeSpan += ( nowTimeSpan - lastTimeSpan );
		lastTimeSpan = nowTimeSpan;

		if ( elapsedTimeSpan.TotalMilliseconds >= Speed )
		{
			UnityEngine.GameObject createdObject;
			int random = UnityEngine.Random.Range ( 0, 3 );
			createdObject = Instantiate ( Meteor ) as GameObject;
			createdObject.transform.position = new Vector3 ( 2 + ( ( random == 0 ) ? -1 : ( ( random == 1 ) ? 0 : 1 ) ) * PositionUnit, 0, 4 );
			createdObject = Instantiate ( Meteor ) as GameObject;
			createdObject.transform.position = new Vector3 ( 2 + ( ( random == 0 ) ? 1 : ( ( random == 1 ) ? -1 : 0 ) ) * PositionUnit, 0, 4 );

			random = UnityEngine.Random.Range ( 0, 10 );
			if ( random == 0 )
			{
				random = UnityEngine.Random.Range ( 0, 5 );
				switch ( random )
				{
					case 0:
						break;
					case 1:
						break;
					case 2:
						break;
					case 3:
						break;
					case 4:
						break;
				}
			}

			elapsedTimeSpan = new TimeSpan ();
			if ( Speed > 500 )
				Speed -= 100;
		}
	}
}