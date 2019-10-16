using UnityEngine;
using System.Collections;

public class ShowDistance : MonoBehaviour
{
	public static float Distance = 0;

	void Start ()
	{
		Distance = 0;
	}

	void Update ()
	{
		if ( GameOverChecker.IsGameOver ) return;
		Distance += 0.01f * ( 3000.0f / ObjectCreator.Speed );
	}

	void OnGUI ()
	{
		GUIStyle guiStyle = new GUIStyle ()
		{
			fontSize = 20,
		};
		guiStyle.normal.textColor = new Color ( 1, 1, 1, 1 );
		GUI.Label ( new Rect ( 10, 10, 400, 100 ), string.Format ( "Distance: {0:0.0}km\nSpeed: {1:0.00}km/h",
			Distance, ( 3000.0f / ObjectCreator.Speed ) * 100 ), guiStyle );
	}
}
