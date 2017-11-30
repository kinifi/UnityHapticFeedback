using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.iOS.Haptic;

public class testingHaptic : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Haptic.Create();
	}

	public void OnGUI() {

		if(GUILayout.Button("Haptic Success", GUILayout.Height(300), GUILayout.Width(300))) {
			Haptic.Feedback_Success();
			Debug.Log("Feedback Success");
		}

		if(GUILayout.Button("Haptic Warning", GUILayout.Height(300), GUILayout.Width(300))) {
			Haptic.Feedback_Warning();
			Debug.Log("Feedback Warning");
		}

		if(GUILayout.Button("Haptic Error", GUILayout.Height(300), GUILayout.Width(300))) {
			Haptic.Feedback_Error();
			Debug.Log("Feedback Error");
		}

		GUILayout.Space(10);

		if(GUILayout.Button("Impact Light", GUILayout.Height(300), GUILayout.Width(300))) {
			Haptic.Impact_Light();
			Debug.Log("Impact Light");
		}

		if(GUILayout.Button("Impact Medium", GUILayout.Height(300), GUILayout.Width(300))) {
			Haptic.Impact_Medium();
			Debug.Log("Impact Medium");
		}

		if(GUILayout.Button("Impact Heavy", GUILayout.Height(300), GUILayout.Width(300))) {
			Haptic.Impact_Heavy();
			Debug.Log("Impact Heavy");
		}

	}
	
	
}
