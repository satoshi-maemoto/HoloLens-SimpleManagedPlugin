using SimplePlugin;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
        this.GetComponent<TextMesh>().text = Plugin.SayHello();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
