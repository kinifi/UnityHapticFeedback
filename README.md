# UnityHapticFeedback

iOS Haptic and Notification Feedback Wrapper for Unity

### Setup

You must use the 
```
namespace UnityEngine.iOS.Haptics;
```


### API

- ``` void Create() ```
- ``` void Feedback_Success() ```
- ``` void Feedback_Warning() ```
- ``` void Feedback_Error() ```
- ``` void Impact_Light() ```
- ``` void Impact_Medium() ```
- ``` void Impact_Heavy() ```


### Linking The Frameworks

After building your XCode Project in Unity, you must do the following steps:
- Build Settings -> Dead Code Stripping -> YES
- General -> Deployment Target -> 10.0 or Higher
- General -> Drag the UnityHaptics.framework file (Found in the Folder Structure of your project under Frameworks->Plugins->iOS) onto Embedded Frameworks

- Build to make sure everything is good! 
