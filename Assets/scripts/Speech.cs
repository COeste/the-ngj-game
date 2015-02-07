using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Speech : MonoBehaviour {

	Text text;

	private int textseq = 0;

	// Use this for initialization
	void Awake () {
		text = GetComponent<Text> ();
		text.text = "Hello!:3";
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyUp (KeyCode.Space)) {
			textseq++;
		}
		if (textseq == 1) {
			text.text = "blablabla";
		}
		else
		{
			if(textseq == 2){
				text.text = "other stuff";
			}
			else
			{
				if(textseq == 3)
				{
					text.text = "made it!";
				}
			}
		}

	}
}
