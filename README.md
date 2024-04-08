
# ARcademy

## Introduction

Welcome to ARcademy! Traditional educational methods often struggle to engage young learners effectively. Augmented Reality (AR) technology presents an opportunity to transform education by providing immersive, interactive, and engaging learning experiences.

With AR, we bridge the gap between abstract concepts and tangible understanding. Through dynamic 3D models, animations, and simulations, ARcademy brings textbook content to life. Students can explore complex ideas in a captivating and interactive manner, fostering deeper comprehension and retention.

Our solution is not only effective but also cost-efficient, making immersive learning experiences accessible to all educational institutions. By leveraging AR technology, we aim to spark curiosity, foster a love for learning, and empower students to explore, discover, and learn in unprecedented ways.

## Technology Introduction

### Unity

Unity is a cross-platform game engine developed by Unity Technologies. It is widely used for developing interactive applications, including games and AR/VR experiences. 

### Augmented Reality (AR)

Augmented Reality (AR) technology overlays digital content onto the real world, enhancing the user's perception and interaction with their environment. AR has immense potential in education, offering immersive and interactive learning experiences.

### Blender, Canva, Figma, PicsArt

- *Blender:* A free and open-source 3D creation software used for modeling, animation, and rendering.
- *Canva:* A graphic design platform that allows users to create presentations, social media graphics, posters, and other visual content.
- *Figma:* A collaborative interface design tool used for prototyping, wireframing, and user interface design.
- *PicsArt:* A mobile photo editing app that offers a wide range of creative tools and effects for enhancing images.

## Solving the Problem

We recognize the challenge of traditional learning methods in engaging students and fostering meaningful understanding. ARcademy addresses this by providing a captivating and interactive learning experience that resonates with students of all ages.

Through the integration of AR technology, we transform static textbook content into dynamic and immersive learning experiences. By augmenting 3D models, animations, and simulations onto real-world objects, we make abstract concepts tangible and accessible, fostering deeper comprehension and retention.

Our use of engaging content creation tools like Blender, Canva, Figma, and PicsArt ensures that educational material is not only informative but also visually appealing and captivating. By combining cutting-edge technology with creative design, we create an educational experience that inspires curiosity and ignites a passion for learning.

## Acknowledgement

We extend our sincere gratitude to the organizers of Wittyhack 4.0 in Indore for providing the platform to showcase our innovation. Their commitment to fostering innovation and addressing real-world challenges has been instrumental in the development of ARcademy.

Additionally, we would like to acknowledge the invaluable support and resources provided by NMIMS College Indore, which played a crucial role in the success of our project. Their guidance and encouragement have been invaluable throughout the development process.

Finally, we express our gratitude to the data and code contributors who have generously shared their expertise and insights, contributing to the ongoing improvement and enhancement of ARcademy.

---

## About the Project

Our goal is to make learning an immersive and interactive experience for children. With ARcademy, we aim to:

- *Foster a love for learning by making it fun and engaging.*
- *Enhance comprehension and retention of educational concepts.*
- *Provide an alternative to traditional learning methods that may not resonate with all children.*

## Key Features

- *AR Technology:* Augment the 3D model of images from textbooks, transforming them into interactive and dynamic learning experiences.
- *Engaging Content:* Provide educational content that is both informative and entertaining, capturing the attention of young learners.
- *User-Friendly Interface:* Design an intuitive and easy-to-use interface that is accessible to children of all ages.

## How It Works

ARcademy utilizes the camera on compatible devices to detect images from textbooks. Once detected, these images are augmented with interactive 3D models, animations, and additional information, creating an immersive learning environment.

## Getting Started

### Prerequisites

- *Minimum Android API Level 28:* ARcademy requires a minimum Android API Level of 28 to run smoothly on compatible devices.
- *NCERT Books:* The app is designed to augment content from NCERT (National Council of Educational Research and Training) books. Ensure you have access to these textbooks for the best learning experience.

### Installation

To install ARcademy:
1. Download the APK file from the provided source.
2. Enable installation from unknown sources in your device settings.
3. Install the APK file on your Android device.

### How to use Scripts
# Touch Input Script (touchinput.cs)

This script enables touch-based interactions for zooming and rotating a GameObject in Unity.

## Parameters

- `zoomSpeed`: Controls the speed of zooming.
- `minZoom`: Minimum scale size allowed for zooming.
- `maxZoom`: Maximum scale size allowed for zooming.
- `rotationSpeed`: Speed of rotation.

## How to Use

1. **Attach Script to GameObject**:
   - Attach the `touchinput.cs` script to a GameObject in your Unity scene.

2. **Set Parameters**:
   - Configure the following parameters in the Inspector:
     - `zoomSpeed`: Adjust the speed of zooming.
     - `minZoom`: Set the minimum scale size allowed for zooming.
     - `maxZoom`: Set the maximum scale size allowed for zooming.
     - `rotationSpeed`: Adjust the speed of rotation.

3. **Interact with GameObject**:
   - Run the Unity scene on a touch-enabled device.
   - Touch the GameObject on the screen:
     - Swipe up/down to zoom in/out (single-touch).
     - Swipe left/right to rotate the GameObject (single-touch).

4. **Testing and Adjustment**:
   - Test the touch interactions with the GameObject.
   - Adjust the parameters in the Inspector to achieve desired zoom and rotation behavior.
     ![brain](https://github.com/Wittyhacks4CR004/WH038_AugmentRise/assets/117833599/ce4f72b0-1ee8-425e-9aeb-7aabdcfdebf1)
     
![image](https://github.com/Wittyhacks4CR004/WH038_AugmentRise/assets/117833599/1e5e7a0c-d794-40d0-85f0-80be0da58c22)

## Example Code
using UnityEngine;

public class touchinput : MonoBehaviour
{
    public float zoomSpeed = 0.5f;
    public float minZoom = 0.5f;
    public float maxZoom = 5f;
    public float rotationSpeed = 2f;

    private bool isDragging = false;
    private Vector2 lastPosition;

    void Update()
    {
        if (Input.touchCount == 1)
        {
            Touch touch = Input.GetTouch(0);

            // Zoom
            if (touch.phase == TouchPhase.Moved)
            {
                float zoomDelta = touch.deltaPosition.y * zoomSpeed * Time.deltaTime;
                ZoomObject(zoomDelta);
            }

            // Rotate
            if (touch.phase == TouchPhase.Began)
            {
                isDragging = true;
                lastPosition = touch.position;
            }
            else if (touch.phase == TouchPhase.Moved && isDragging)
            {
                Vector2 delta = touch.position - lastPosition;
                RotateObject(delta.x);
                lastPosition = touch.position;
            }
            else if (touch.phase == TouchPhase.Ended)
            {
                isDragging = false;
            }
        }
    }

    void ZoomObject(float delta)
    {
        Vector3 scale = transform.localScale;
        float newSize = Mathf.Clamp(scale.x - delta, minZoom, maxZoom);
        transform.localScale = new Vector3(newSize, newSize, newSize);
    }

    void RotateObject(float delta)
    {
        transform.Rotate(Vector3.up, -delta * rotationSpeed);
    }
}

# Backbutton Script (Backbutton.cs)

This script allows for scene switching in Unity by loading a specified scene name.
![image](https://github.com/Wittyhacks4CR004/WH038_AugmentRise/assets/117833599/030180ab-cec5-46f4-a70f-aff51c7ed1a2)

![image](https://github.com/Wittyhacks4CR004/WH038_AugmentRise/assets/117833599/9ab19893-b5ce-41f2-ae6c-fdd3559c43fa)

## How to Use

1. **Attach Script to GameObject**:
   - Attach the `Backbutton.cs` script to a GameObject in your Unity scene (e.g., UI button).

2. **Set Scene Name**:
   - In the Inspector panel, specify the `namee` variable with the name of the scene you want to load.

3. **Interact with GameObject**:
   - Create an `OnClick` event for your UI button and connect it to the `SceanChanger` method in the `Backbutton` script.

4. **Specify Scene Name**:
   - When setting up the `OnClick` event, input the desired scene name in the `namee` field of the `Backbutton` component.

## Example Code

using UnityEngine;
using UnityEngine.SceneManagement;

public class Backbutton : MonoBehaviour
{
    public string namee;

    public void SceanChanger(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}

## Team Members

- *Eklavya Gautam (3D modeler):* Created 3D models and did animation.
- *Vikas Madhukar (Unity Developer):* Developed the Unity components and functionalities.
- *Utkarsh Upadhyay (AR Specialist):* Implemented AR features and technologies.
- *Tanya Singh (UI Designer):* Designed the user interface and user experience.

## Contact Us

If you have any questions, feedback, or suggestions,
Eklavya Gautam(Team Lead) - +91 8218849567
