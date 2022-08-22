using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class PlayerInput : MonoBehaviour
{
    private Vector3 _playerMovement;
    private float _backforward;
    private Animator _bearAnim;
    private PlayerInputActions _input;
    


    private void Start()
    {
        

        _bearAnim = GetComponent<Animator>();
        _input = new PlayerInputActions();
        _input.Player.Enable();

        _input.Player.Sleep.performed += Sleep_performed;

    }

    private void Sleep_performed(InputAction.CallbackContext obj)
    {
        _bearAnim.SetTrigger("Sleep");

    }

    private void Update()
    {
        AnimationController();
        _backforward = _input.Player.BearWalk.ReadValue<float>();
        transform.Translate(Vector3.forward * Time.deltaTime * 1f * _backforward);        
        
    }

    void AnimationController()
    {
        

        if (_backforward == 1)
        {
            _bearAnim.SetTrigger("WalkForward");
            _bearAnim.ResetTrigger("Sleep");
        }
        else if(_backforward == -1)
        {
            _bearAnim.SetTrigger("WalkBackward");
            _bearAnim.ResetTrigger("Sleep");
        }
        else
        {
            _bearAnim.ResetTrigger("WalkForward");
            _bearAnim.ResetTrigger("WalkBackward");
        }

        
    }


}
