using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Example : MonoBehaviour {
	public Text display;
	public TextAsset twineScript;

	void Start () {
		Twinity.Parse(twineScript.text);
		PassageModel.Instance.Start();
	}

	void Update()
	{
		display.text = PassageModel.Instance.GetCurrent();
	}
}
