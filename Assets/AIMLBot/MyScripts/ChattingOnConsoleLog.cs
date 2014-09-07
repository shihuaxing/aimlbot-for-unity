using UnityEngine;
using System.Collections;

public class ChattingOnConsoleLog : MonoBehaviour
{
		private Chatbot bot;

		void Start ()
		{
				bot = new Chatbot ();
				string input = "Hello, what is your name";
				var output = bot.getOutput (input);
				Debug.Log (input);
				Debug.Log (output);
		}

}

