using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.Events;

public class ButtonFactory : MonoBehaviour{
	public GameObject ButtonPrefab;

	List<GameObject> buttons = new List<GameObject>();

	int currentPassage = 0;

	void Update(){
		if(PassageModel.Instance.currentPassage != currentPassage){
			UpdateButtons();
			currentPassage = PassageModel.Instance.currentPassage;
		}
	}

	void UpdateButtons(){
		if(PassageModel.Instance.currentLinks.Count < 1){
			ResetButtons();

			CreateButton(() => PassageModel.Instance.Advance(), "Advance");

		} else{
			ResetButtons();

			foreach(Link item in PassageModel.Instance.currentLinks){
				int pid = item.pid;
				CreateButton(() => PassageModel.Instance.Choose(pid), item.text);
			}
		}
	}

	void ResetButtons(){
		foreach(var item in buttons){
			Destroy(item);
		}
		buttons = new List<GameObject>();
	}

	void CreateButton(UnityAction action, string label){
		var b = Instantiate(ButtonPrefab);
		buttons.Add(b);
		b.transform.SetParent(gameObject.transform, false);

		Button c = b.GetComponent<Button>();
		c.onClick.AddListener(action);
		c.GetComponentInChildren<Text>().text = label;
	}
}
