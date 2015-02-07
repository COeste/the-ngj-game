using UnityEngine;
//using UnityEditor;
using System.Collections;

public class scene1 : MonoBehaviour {

	string[] textArray = {"00000000000000000000000", "1111111111111111111111", "22222222222222222222222"};
	int i = 0;
	
	// Update is called once per frame
	void Update () {


	}
	void OnGUI () {
		if (i < textArray.Length) {
			GUI.Label(new Rect(10, 10, 100, 20), textArray[i]);
			if(Event.current.Equals(Event.KeyboardEvent("space"))){
				i++;
			}
		}
	}
}
