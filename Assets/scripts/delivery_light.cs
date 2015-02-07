using UnityEngine;
using System.Collections;

public class delivery_light : MonoBehaviour {

	private float timer = 0F;
	private GameObject[] horizontal_Lights;
	private GameObject[] vertical_Lights;

	// Use this for initialization
	void Start () {
		horizontal_Lights = GameObject.FindGameObjectsWithTag ("hori");
		vertical_Lights = GameObject.FindGameObjectsWithTag ("verti");
	}
	
	// Update is called once per frame
	void Update () {
		timer += Time.deltaTime;
		Debug.Log (timer+ " timer");
		Debug.Log(Mathf.RoundToInt (timer)+" rounded");
		Debug.Log(Mathf.RoundToInt (timer) % 5 + " modulus");
		if (Mathf.RoundToInt (timer) % 10 == 0) {
			Debug.Log ("skifter farve");
			horizontal_Lights [0].renderer.material.color = new Color(255f,0f,0f,1f);
			horizontal_Lights[0].collider2D.enabled = true;
			horizontal_Lights [2].renderer.material.color = new Color(255f,0f,0f,1f);
			horizontal_Lights[2].collider2D.enabled = true;
			vertical_Lights[0].renderer.material.color = new Color(0f,255f,0f,1f);
			vertical_Lights[0].
			vertical_Lights[1].renderer.material.color = new Color(0f,255f,0f,1f);
		} else if (Mathf.RoundToInt (timer) % 5 == 0) {
			horizontal_Lights [0].renderer.material.color = new Color(0f,255f,0f,1f);
			horizontal_Lights [2].renderer.material.color = new Color(0f,255f,0f,1f);
			vertical_Lights[0].renderer.material.color = new Color(255f,0f,0f,1f);
			vertical_Lights[1].renderer.material.color = new Color(255f,0f,0f,1f);
		}
	
	}
}
