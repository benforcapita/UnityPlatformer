using UnityEngine;
using System.Collections;
using System.Collections.Generic;
//buttons state dictionary 
public class ButtonState
{
    public bool value;
    public float holdTime = 0;
 }

public class InputState : MonoBehaviour {

    public Dictionary<Buttons, ButtonState> buttonStates = new Dictionary<Buttons, ButtonState>();
    // Use this for initialization
   

    public void setButtonValue(Buttons key, bool value)
    {
        if (!buttonStates.ContainsKey(key))
        {
            buttonStates.Add(key,new ButtonState());
           
        }
        

        var state = buttonStates[key];
        if(state.value && !value)
        {
          //  Debug.Log("Buuton " + key + " relesed" );
           // state.holdTime = 0;
        }
        else if (state.value && value)
        {
            
           // state.holdTime += Time.deltaTime;
        //    Debug.Log("Buuton " + key + "  down ");
        }

        state.value = value;
    }

    public bool GetButtonValue(Buttons key)
    {
        if (buttonStates.ContainsKey(key))
        {
            return buttonStates[key].value;
        }
        else
        {
            return false;
        }

    }
}
