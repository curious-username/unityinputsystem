using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInput : MonoBehaviour
{
    private Vector3 _playerMovement;
    private Animator _bearAnim;
    private PlayerInputActions _input;
    


    private void Start()
    {


        _bearAnim = GetComponent<Animator>();
        _input = new PlayerInputActions();
        _input.Player.Enable();

        _input.Player.BearWalk.performed += BearWalk_performed;
        _input.Player.Sleep.performed += Sleep_performed;

    }

    private void Sleep_performed(InputAction.CallbackContext obj)
    {
        _bearAnim.SetTrigger("Sleep");

    }

    private void BearWalk_performed(InputAction.CallbackContext obj)
    {
        _playerMovement = obj.ReadValue<Vector3>();
        var _defaultVector3 = new Vector3(0, 0, 0);
        
        
        if(_playerMovement == _defaultVector3)
        {
            _bearAnim.ResetTrigger("WalkForward");
            _bearAnim.ResetTrigger("WalkBackward");
        }
    }





    private void Update()
    {
        AnimationController();
        transform.Translate(_playerMovement * Time.deltaTime * 1f);        
    }

    void AnimationController()
    {
        

        if (_playerMovement.z == 1)
        {
            _bearAnim.SetTrigger("WalkForward");
            _bearAnim.ResetTrigger("Sleep");
        }
        else if(_playerMovement.z == -1)
        {
            _bearAnim.SetTrigger("WalkBackward");
            _bearAnim.ResetTrigger("Sleep");
        }

        
    }


}
