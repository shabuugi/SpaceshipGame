using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class Forces : MonoBehaviour
{
    [SerializeField] float forceStrength = 10f;
    [SerializeField] float torqueStrength = 10f;
    private Rigidbody2D rb;
    [SerializeField] InputAction upForce = new InputAction(type: InputActionType.Button);
    [SerializeField] InputAction leftTorque = new InputAction(type: InputActionType.Button);
    [SerializeField] InputAction rightTorque = new InputAction(type: InputActionType.Button);
    [SerializeField] GameObject forwardIndicator;
    [SerializeField] float maxSpeed = 5f;
    [SerializeField] float maxAngularVelocity = 5f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        upForce.AddBinding("<Keyboard>/upArrow");
        leftTorque.AddBinding("<Keyboard>/leftArrow");
        rightTorque.AddBinding("<Keyboard>/rightArrow");
    }

    private void OnEnable()
    {
        upForce.Enable();
        leftTorque.Enable();
        rightTorque.Enable();
    }

    void FixedUpdate()
    {
        if (upForce.IsPressed() && rb.linearVelocity.magnitude < maxSpeed)
        {
            rb.AddForce(new Vector2(0f, forceStrength) , ForceMode2D.Force);
        }
        if (leftTorque.IsPressed() && rb.angularVelocity < maxAngularVelocity)
        {
            rb.AddTorque(torqueStrength);
        }

        if (rightTorque.IsPressed() && rb.angularVelocity > -maxAngularVelocity)
        {
            rb.AddTorque(-torqueStrength);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
