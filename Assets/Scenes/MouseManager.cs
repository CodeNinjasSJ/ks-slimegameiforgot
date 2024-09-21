using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public Vector3 clickStartLocation;
    public Vector3 launchVector;

    public float launchForce;
    [Header("Slime")]
    public Transform slimeTransform;
    public Rigidbody slimeRigidbody;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            clickStartLocation = Input.mousePosition;
        }

        if (Input.GetMouseButton(0))
        {
            Vector3 mouseDifference = clickStartLocation - Input.mousePosition;
            launchVector = new Vector3(
                mouseDifference.x * -5f,
                mouseDifference.y * 1.2f,
                mouseDifference.y * -1.5f
                );
            launchVector.Normalize();
        }

        if (Input.GetMouseButtonUp(0))
        {
            slimeRigidbody.isKinematic = false; // Makes the rigidbody affected by physics
            slimeRigidbody.AddForce(launchVector * launchForce, ForceMode.Impulse); // Adds an impulse force
            print("release");
        }
        
           
        
    }
}
