using UnityEngine;
using System.Collections;
public enum Buttons { 
    Left,
    right,
    Up,
    Down,
    A,
    B
}
public enum Condition
{
    GreaterThen,
    LessThen
}
[System.Serializable]
public class inputAxisState
{
    public string axisName;
    public float offValue;
    public Buttons buttons;
    public Condition condition;

    public bool value
    {
        get
        {
            var val = Input.GetAxis(axisName);
            switch (condition)
            {
                case Condition.GreaterThen:
                    return val > offValue;
                case Condition.LessThen:
                    return val < offValue;
                default:
                    return false;
            }
        }
    }

}

public class InputManger : MonoBehaviour
{

    public inputAxisState[] inputs;
    public InputState inputStae;

    void Start()
    {
        if(inputStae== null)
        {
            foreach (var P in GameObject.FindObjectsOfType<InputState>())
            {
                if (P.gameObject.tag == "Player")
                {
                    inputStae = P;
                }
            }
        }
       
    }

        // Update is called once per frame
        void Update()
        {
            foreach (var input in inputs)
            {
                inputStae.setButtonValue(input.buttons, input.value);
               }

        }
    }