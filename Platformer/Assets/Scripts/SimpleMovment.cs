using UnityEngine;
using System.Collections;

public class SimpleMovment : MonoBehaviour {
    public float speed = 5f;
    public Buttons[] input;
    
    private Rigidbody2D body2D;
    private InputState intputstates;

    // Cheackkkk if commite is workkking
	// Use this for initialization
	void Start () {
        body2D = GetComponent<Rigidbody2D>();
        intputstates = GetComponent<InputState>();
    }
	
	// Update is called once per frame
	void Update () {
        bool right = intputstates.GetButtonValue(input[0]);
        bool left = intputstates.GetButtonValue(input[1]);
        float velX = speed;
        if(right || left )
        {
           if(left)
            {
                velX = 0;
                velX += -1;
                Debug.Log(velX);
                   
            }
           else
            {
                velX = 0;
                velX += 1;
                Debug.Log(velX);
            }
        }
       else
        {
            velX = 0;
        }
       // Debug.Log(left);
        body2D.velocity = new Vector2(velX*speed, body2D.velocity.y);

    }
}
