# UnityTips
My trove of Unity Tips **#unitytips** I’ve learned over the years.  

## Twinity - A Twine Parser
Ever thought of creating your own text adventure? [Twine](https://twinery.org), originally created by Chris Klimas, lets you create non-linear, interactive storytelling, that you can distribute as an HTML page.

You can find a selection of Twine games [here](https://itch.io/games/tag-twine).

Twine games can be created with easy to use web and desktop apps. 

I made Twinity to allow you to easily import twine games into Unity.

### Instructions
1. Create your adventure in Twine’s official apps.
2. Use Lazerwalker’s [Twison](https://github.com/lazerwalker) to export your twine into JSON.
3. Import your JSON into Unity using Twinity.
4. All the dialogue’s passages and choices are parsed and you can play through them via the included demo scene.

Makes use of Unify Community’s [Singleton](http://wiki.unity3d.com/index.php/Singleton) and [SimpleJSON](http://wiki.unity3d.com/index.php/SimpleJSON).

Includes an example Twine exported with Twison into JSON.

***

## Scriptable Objects
Scriptable Objects are a great feature of Unity that everyone should know about.
These assets serve as containers of other resources, of any type of object you can have in Unity: **prefabs**, **text**, **images**, **textures**, **materials**, **sounds**, etc…

Rather than hardcode paths to filenames in the *Resources* folder, you can instead link to a specific asset slot within a **Scriptable Object** (SO).
Then, on that **SO**, you can assign resources from anywhere in the project to that slot. Now you can switch around resources on that **SO** and without changing the rest of your code, your game will load all the new objects in the **SO**.
 
It’s incredibly useful, and a must for your Unity projects.

In this example project are two scripts that allow you to create Scriptable Objects, and a demo scene with a cube linked to a SO defined material. Try switching the material in the Scriptable Object to change the cube!

### Notes
- Scriptable Objects are defined by their classes, that you write
- **ScriptableObjectExample** in this project consists of an object name, a color and a material
- Any changes to the SOs class are reflected in Unity after it recompiles the scripts
- SOs can be created by the menu
- *MakeScriptableObject* adds a menu item to Assets/Create to instantiate a new SO
- Alternatively, you can add a menu item on the Scriptable Object’s class itself: 

```
[CreateAssetMenu(fileName = "Scriptable Object", menuName = "Examples/Scriptable Object", order = 1)]
public class ScriptableObjectExample : ScriptableObject {
```

- Changes in scriptable objects are always saved, whether or not they were made in Play or Editor modes.

You can find out more about Scriptable Objects at [Unity learn](https://unity3d.com/learn/tutorials/modules/beginner/live-training-archive/scriptable-objects).

