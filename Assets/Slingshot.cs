using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slingshot : MonoBehaviour
{
    private Rigidbody2D rigidBody;

    // public float speed = 1f;

    public Vector2 onMouseUp;
    public Vector2 onMouseDown;

    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
        // Vector2 test = new Vector2(5.0f, 2.0f);
        // rigidBody.AddForce(test * 10.0f);
    }

    // Update is called once per frame
    void Update()
    {
    
    }

    void OnMouseDown() 
    {
        onMouseDown = Input.mousePosition;
    }

    void OnMouseDrag() 
    {
        // if (Input.GetButtonUp("Fire1")) {
        //    Debug.Log(Input.mousePosition);
        // }    
    }

    void OnMouseUp() {
        onMouseUp = Input.mousePosition;
        Vector2 distanceToGo = onMouseDown - onMouseUp;
        Debug.Log("Before normalize" + distanceToGo);
        // distanceToGo.Normalize();
        // Debug.Log("after normalize" + distanceToGo * 10f);
        // distanceToGo.up = distanceToGo.up * 20f;
        // distanceToGo.right = distanceToGo.right * 20f;
        rigidBody.AddForce(distanceToGo * 1f);
    }
}
