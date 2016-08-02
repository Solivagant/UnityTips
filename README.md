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



