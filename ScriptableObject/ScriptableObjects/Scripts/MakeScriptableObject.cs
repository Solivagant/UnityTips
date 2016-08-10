using UnityEngine;
using System.Collections;
using UnityEditor;

public class MakeScriptableObject {
    [MenuItem("Assets/Create/My Scriptable Object")]
    public static void CreateMyAsset()
    {
		ScriptableObjectExample asset = ScriptableObject.CreateInstance<ScriptableObjectExample>();

        AssetDatabase.CreateAsset(asset, "Assets/NewScriptableObject.asset");
        AssetDatabase.SaveAssets();

        EditorUtility.FocusProjectWindow();

        Selection.activeObject = asset;
    }
}
