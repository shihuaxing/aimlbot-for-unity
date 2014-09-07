using UnityEngine;
using System.Collections;
using System.IO;
using System;

public class ReadText : MonoBehaviour
{
		private Vector2 scrollPosition;
		private Rect windowRect = new Rect (200, 200, 300, 400);
		private string filePath = "";
		private string result = "";

		void Start ()
		{
		filePath = Path.Combine (Application.streamingAssetsPath, "License.txt");
				StartCoroutine (GetText ());
		}

		IEnumerator GetText ()
		{
				if (filePath.Contains ("://")) {
						WWW www = new WWW (filePath);
						yield return www;
						result = www.text;
				} else {
						result = File.ReadAllText (filePath);
				}
		}
	
		void OnGUI ()
		{
				windowRect = GUI.Window (0, windowRect, windowFunc, "License");
		}
	
		private void windowFunc (int id)
		{			
				scrollPosition = GUILayout.BeginScrollView (scrollPosition, GUILayout.Height (350));
				GUILayout.Label (result);
				GUILayout.EndScrollView ();

				/*GUILayout.BeginHorizontal ();
				GUILayout.Label (result);
				GUILayout.EndHorizontal ();*/
		
				GUI.DragWindow (new Rect (0, 0, Screen.width, Screen.height));
		}//fecha windowFunc
	
	
}//fecha Classe
