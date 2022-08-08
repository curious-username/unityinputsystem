using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInput : MonoBehaviour
{
    //get a reference and start an instanceof our input actions
    //enable input action map, which map? dog.
    //register the perform functions

    private PlayerInputActions _input;
    [SerializeField] AudioSource _bark;
    private float _speed = 5.0f;
    private float _run = 5.0f;
    private Vector2 movement;
    
    

    private void Start()
    {
        _input = new PlayerInputActions();
        _input.Dog.Enable();
        _input.Dog.Bark.performed += Bark_performed;
        _input.Dog.Walk.performed += Walk_performed;
        _input.Dog.Walk.canceled += Walk_canceled;
        _input.Dog.Run.performed += Run_performed;
        _input.Dog.Run.canceled += Run_canceled;
        
        
    }

    private void Run_canceled(InputAction.CallbackContext obj)
    {
        Debug.Log("Run Cancelled");
    }

    private void Run_performed(InputAction.CallbackContext obj)
    {
        Debug.Log("Run");
    }

    private void Walk_canceled(InputAction.CallbackContext obj)
    {
        movement = new Vector2(0, 0);
    }

    private void Update()
    {
        transform.Translate(movement * _speed * Time.deltaTime);
    }

    private void Walk_performed(InputAction.CallbackContext obj)
    {
        movement = obj.ReadValue<Vector2>();
       
    }

    private void Bark_performed(InputAction.CallbackContext obj)
    {
        _bark.Play();
    }

    

}
