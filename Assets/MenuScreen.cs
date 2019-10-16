using UnityEngine;
using System.Collections;

public class MenuScreen : MonoBehaviour
{

	// Use this for initialization
	void Start ()
	{

	}

	// Update is called once per frame
	void Update ()
	{
		if ( Input.GetMouseButtonDown ( 0 ) )
		{
			Application.LoadLevel ( "GameScene" );
		}
	}

	void OnGUI ()
	{
		GUIStyle style = new GUIStyle ();
		style.normal.textColor = new Color ( 1, 1, 1, 1 );
		style.fontSize = 64;
		style.fontStyle = FontStyle.Bold;
		GUI.Label ( new Rect ( 40, 40, 300, 300 ), "Captain Bear", style );

		style = new GUIStyle ();
		style.normal.textColor = new Color ( 1, 1, 1, 1 );
		style.fontSize = 32;
		GUIContent content = new GUIContent ( "Click to screen to game start" );
		Vector2 v = style.CalcSize ( content );
		GUI.Label ( new Rect ( Screen.width / 2 - v.x / 2, Screen.height - v.y * 2, v.x, v.y ), content, style );
	}
}
