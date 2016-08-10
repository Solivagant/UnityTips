using UnityEngine;
using System.Collections;

[CreateAssetMenu(fileName = "Scriptable Object", menuName = "Examples/Scriptable Object", order = 1)]
public class ScriptableObjectExample : ScriptableObject {
	public string objectName = "Object Name";
    public Color enemyColor;
    public Material material;
}
