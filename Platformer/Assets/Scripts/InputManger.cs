using UnityEngine;
using System.Collections;
public enum Buttons
{
    Right,
    Left,
    Jump
}
[System.Serializable]
public class inputAxisState
{
    public string axisName;
    public float offValue;
    public Buttons buttons;

}

public class InputManger : MonoBehaviour {

    public inputAxisState[] inputs;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
