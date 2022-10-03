# unity-ar-measure-example
Example project showing an AR measure tool in Unity. This project contains two scenes with different measurement techniques:
- CursorMeasureScene: select button to add a line point within the onscreen reticle. Line point is added at x, y reticle location and z axis intersection of plane. Only 2 total line points can be added.
- TapMeasureScene: tap anywhere on screen to add points to a continuously growing line. Line point is added at x, y tapped location and z axis intersection of plane.

## Supported Platforms
This project is designed for use on both iOS and Android.

## Running locally
Use the following steps to run locally:
1. Clone this repo
2. Open repo folder using Unity 2021.3.10f1
3. Install TextMeshPro

## Development
Setup steps to be able to include AR Foundation and build and deploy:
- Install AR Foundation located in the Package Manager under AR Foundation
- Install ARKit located in the Package Manager under AR Kit XR Plugin (required for iOS devices)
- Install ARCore located in the Package Manager under AR Core XR Plugin (required for Android devices)
- Install com.unity.xr.interaction.toolkit package (need to install by name, and click yes on dialog that appears with information about the input system)
- In Project Settings > XR Plug-in Management, set the Plug-in Provider on the Android tab to ARCore
- In Project Settings > XR Plug-in Management, set the Plug-in Provider on the iOS tab to ARKit
- Ensure AR scenes contain an AR Session and AR Session Origin
- Turn off multithreading
- In Project Settings > Resolution and Presentation, disable Render Outside Safe Space
- For Android, in Project Settings > Other Settings, set Minimum API Level to Android API level 24 or higher (this is required to build for Android)
- For Android, in Project Settings > Other Settings, remove Vulkan from Graphics APIs (this is required to build for Android, need to uncheck Auto Graphics API first)
- For Android, in Project Settings > Other Settings, Set Scripting Backend to IL2CPP
- For Android, in Project Settings > Other Settings, Add ARM64 to Target Architectures
- For iOS, set Camera Usage Description in build settings

## Development Tools
- Created using Unity 2021.3.10f1
- Code edited using Visual Studio Code

## Credits
AR setup based on this tutorial:
https://www.youtube.com/watch?v=R3OCUE9TwZk

Code and scene structure used in CursorMeasureScene is based on this tutorial:
https://www.youtube.com/playlist?list=PLb1h4A0yB97_ehIJzf25vmJ2MqScUuk--

Code and scene structure used in TapMeasureScene is an amalgamation of the above and this tutorial:
https://www.youtube.com/watch?v=R3OCUE9TwZk



