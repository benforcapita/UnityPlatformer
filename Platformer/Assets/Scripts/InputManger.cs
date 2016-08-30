using UnityEngine;
using System.Collections;
public enum Buttons { 
    Left,
    right,
    Jump
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


        // Update is called once per frame
        void Update()
        {
            foreach (var input in inputs)
            {
                if (input.value == true)
                {
                    Debug.Log("Input Detacted " + input.buttons);
                }
            }

        }
    }