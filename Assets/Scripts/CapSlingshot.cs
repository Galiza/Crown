using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CapSlingshot : MonoBehaviour
{
    private Vector3 initialpos;
    private Vector3 finalPos;
    private TrailRendererWith2DCollider trailManager;
    private bool hasMoved = false;
    private bool isMoving = false;
    // private MeshCollider meshCollider;
    private PolygonCollider2D polygonCollider;
    private TrailRenderer tRendered;
    private Rigidbody2D rigidBody;
    private Vector3 distanceToGo;
    private Vector3 onMouseUp;
    private Vector3 onMouseDown;

    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
        tRendered = GetComponent<TrailRenderer>();

        trailManager = GetComponent<TrailRendererWith2DCollider>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnMouseDown()
    {
        initialpos = this.transform.position;
        onMouseDown = Input.mousePosition;
    }

    void OnMouseDrag()
    {

    }

    void OnMouseUp()
    {
        onMouseUp = Input.mousePosition;
        distanceToGo = onMouseDown - onMouseUp;
        rigidBody.AddForce(distanceToGo * 1f);
        // if (trailManager.trail == null && rigidBody.velocity.magnitude.Equals(0)) {
            trailManager.Build();
        // }
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.name.Contains(this.name))
        {
            Debug.Log("belong to same object");
        }
        else
        {
            Debug.Log("DOES NOT belong to same object");
        }
        // var rel = rigidBody.position - col.attachedRigidbody.position;

        // rigidBody.AddForce(rel * 1f);

    }
}
