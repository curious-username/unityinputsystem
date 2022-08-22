using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Test : MonoBehaviour
{

    PlayerInputActions _input;
    private float x, y, z;
    // Start is called before the first frame update
    void Start()
    {
        _input = new PlayerInputActions();
        _input.SpinMe.Enable();
      
    }


    // Update is called once per frame
    void Update()
    {
        var rotateDirection = _input.SpinMe.Go.ReadValue<float>();
        transform.Rotate(Vector3.right * Time.deltaTime * 30f * rotateDirection);
    }
}
