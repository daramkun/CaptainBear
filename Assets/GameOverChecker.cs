using UnityEngine;
using System.Collections;

public class GameOverChecker : MonoBehaviour {

	public static bool IsGameOver = false;

	// Use this for initialization
	void Start () {
		IsGameOver = false;
	}
	
	// Update is called once per frame
	void Update () {
		if ( IsGameOver )
		{
			if ( Input.GetMouseButtonDown ( 0 ) )
			{
				Application.LoadLevel ( "MenuScene" );
			}
		}
	}

	void OnGUI ()
	{
		if ( IsGameOver )
		{
			GUIContent content = new GUIContent ( "GAME OVER" );
			GUIStyle style = new GUIStyle ();
			style.fontSize = 64;
			style.fontStyle = FontStyle.Bold;
			style.normal.textColor = new Color ( 1, 1, 1, 1 );
			Vector2 v = style.CalcSize ( content );
			GUI.Label ( new Rect ( Screen.width / 2 - v.x / 2, Screen.height / 2 - v.y / 2, v.x, v.y ), content, style );
		}
	}
}
