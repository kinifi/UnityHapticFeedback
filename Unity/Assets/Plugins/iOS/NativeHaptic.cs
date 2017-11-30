using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using AOT;
using System.Runtime.InteropServices;
using System.Text;
using System;

public class NativeHaptic : MonoBehaviour {

	#if UNITY_IOS
		[DllImport ("__Internal")]
		private static extern void Test();
	#endif

	///<Summary>
	/// Initializes and Creates a Peer and a Session
	/// <param name="displayName">The Name That Displays To People Trying To Connect</param>
	///</Summary>
	public static void TestMethod() {
		#if UNITY_IOS 
			if (Application.platform == RuntimePlatform.IPhonePlayer) {

			}
		#else
			Debug.Log("Called Test");
		#endif
	}

}
