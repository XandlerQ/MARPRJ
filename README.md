# MARPRJ

**MARPRJ** is a Unity-based augmented reality (AR) demo application designed to assist with medical targeting, built using [Vuforia](https://developer.vuforia.com/home).

This project showcases AR's potential in medical applications by overlaying a segmented 3D anatomical model—extracted from real CT scan data using [TotalSegmentator](https://github.com/wasserth/TotalSegmentator)—onto an image target.

## Features

- **AR Visualization**: Displays a detailed 3D torso model on an image marker.
- **Targeting Simulation**: Three internal targets are positioned inside the torso for a simulated operation task.
- **Tool Navigation**: A second image target represents a surgical tool. The user must move this tool to reach each internal target.
- **Guidance System**: A directional arrow helps guide the user to the next target.
- **Transparent Focus Effect**: A custom shader material creates a dynamic transparent window in the 3D model to visualize the tool’s path.

## Demo Video

Watch the demo in action:  
🎥 [Demo Video](https://drive.google.com/file/d/1dXInNCd8cfdRJtaB1D4bip0M5vmiPy1y/view?usp=sharing)
