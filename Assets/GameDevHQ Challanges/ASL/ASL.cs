using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;


public class ASL : MonoBehaviour
{
    public Text mainText;
    public Button option1;
    public Button option2;

    [SerializeField] private int _age;
    [SerializeField] private string _gender;
    [SerializeField] private string _location;

    

    // Start is called before the first frame update
    void Start()
    {
        PlayerInputActions _input = new PlayerInputActions();
        
        _input.ASL.PrintASL.Enable();
        _input.ASL.PrintASL.performed += PrintASL_performed1;
        mainText.text = "Weomce to the game!";
        option1.GetComponentInChildren<Text>().text = "Hello";
        option1.GetComponentInChildren<Text>().text = "Hello";



    }

    private void PrintASL_performed1(InputAction.CallbackContext obj)
    {
        Debug.Log(_age + _gender + _location);
    }


}
