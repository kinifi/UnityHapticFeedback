using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using AOT;
using System.Runtime.InteropServices;
using System.Text;
using System;

namespace UnityEngine.iOS.Haptic {

	public class Haptic : MonoBehaviour {

		#if UNITY_IOS

			[DllImport("__Internal")]
			private static extern void Initialize();

			[DllImport ("__Internal")]
			private static extern void hapticSuccess();
			
			[DllImport ("__Internal")]
			private static extern void hapticWarning();
		
			[DllImport ("__Internal")]
			private static extern void hapticError();
		
			[DllImport ("__Internal")]
			private static extern void impactLight();

			[DllImport ("__Internal")]
			private static extern void impactMedium();
			
			[DllImport ("__Internal")]
			private static extern void impactHeavy();


		#endif

		///<Summary>
		/// Haptic Feedback - Init
		///</Summary>
		public static void Create() {
			#if UNITY_IOS 
				if (Application.platform == RuntimePlatform.IPhonePlayer) {
					Initialize();
				}
			#else
				Debug.Log("Called HapticFeedback_Success");
			#endif
		}

		///<Summary>
		/// Haptic Feedback - Success notification
		///</Summary>
		public static void Feedback_Success() {
			#if UNITY_IOS 
				if (Application.platform == RuntimePlatform.IPhonePlayer) {
					hapticSuccess();
				}
			#else
				Debug.Log("Called HapticFeedback_Success");
			#endif
		}


		///<Summary>
		/// Haptic Feedback - Warning notification
		///</Summary>
		public static void Feedback_Warning() {
			#if UNITY_IOS 
				if (Application.platform == RuntimePlatform.IPhonePlayer) {
					hapticWarning();
				}
			#else
				Debug.Log("Called HapticFeedback_Warning");
			#endif
		}

		///<Summary>
		/// Haptic Feedback - Error notification
		///</Summary>
		public static void Feedback_Error() {
			#if UNITY_IOS 
				if (Application.platform == RuntimePlatform.IPhonePlayer) {
					hapticError();
				}
			#else
				Debug.Log("Called HapticFeedback_Error");
			#endif
		}

		///<Summary>
		/// Impact Light Notification
		///</Summary>
		public static void Impact_Light() {
			#if UNITY_IOS 
				if (Application.platform == RuntimePlatform.IPhonePlayer) {
					impactLight();
				}
			#else
				Debug.Log("Called Impact Light");
			#endif
		}

		///<Summary>
		/// Impact Medium Notification
		///</Summary>
		public static void Impact_Medium() {
			#if UNITY_IOS 
				if (Application.platform == RuntimePlatform.IPhonePlayer) {
					impactMedium();
				}
			#else
				Debug.Log("Called Impact Medium");
			#endif
		}

		///<Summary>
		/// Impact heavy Notification
		///</Summary>
		public static void Impact_Heavy() {
			#if UNITY_IOS 
				if (Application.platform == RuntimePlatform.IPhonePlayer) {
					impactHeavy();
				}
			#else
				Debug.Log("Called Impact Heavy");
			#endif
		}

	}

}
