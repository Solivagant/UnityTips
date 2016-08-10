using UnityEngine;
using System.Collections;

public class ApplyMaterial : MonoBehaviour {
	public ScriptableObjectExample so;

	void Start () {
	
	}
	
	void Update () {
		GetComponent<MeshRenderer>().material = so.material;
	}
}
