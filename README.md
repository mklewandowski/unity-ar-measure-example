# unity-ar-measure-example
Example project showing an AR measure tool in Unity.

## Supported Platforms
This project is designed for use on both iOS and Android.

## Running locally
Use the following steps to run locally:
1. Clone this repo
2. Open repo folder using Unity 2021.3.3f.1
3. Install TextMeshPro

## Development
Some required and useful modifications:
- Set Minimum API Level to Android API level 24 or higher (this is required to build for Android)
- Remove Vulkan from Graphics APIs (this is required to build for Android)
- Disable Render Outside Safe Space
- Disable Start in Fullscreen Mode
- Turn off multithreading
- Install com.unity.xr.interaction.toolkit package (need to install by name, and click yes on dialog that appears with information about the input system)
- Set Camera Usage Description on iOS build settings
- Check ARKit in XR Plug-in Management in iOS build settings

## Development Tools
- Created using Unity 2020.3.10f.1
- Code edited using Visual Studio Code

## Credits
Code and scene structure is based on this tutorial:
https://www.youtube.com/playlist?list=PLb1h4A0yB97_ehIJzf25vmJ2MqScUuk--

AR setup based on this tutorial:
https://www.youtube.com/watch?v=R3OCUE9TwZk


