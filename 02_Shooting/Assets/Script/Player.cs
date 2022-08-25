using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    PlayerInputAction inputActions;
    // Awake -> OnEnable -> start : 대체적으로 이 순서
    Vector3 dir;
    public float speed = 1.0f;

    /// <summary>
    /// 이 스크립트가 들어있는 게임 오브젝트가 생성된 직후에 호출
    /// </summary>
    private void Awake()
    {
        inputActions = new PlayerInputAction();
    }

    /// <summary>
    /// 이 스크립트가 들어있는 게임 오브젝트가 활성화 되었을 때 호출
    /// </summary>
    private void OnEnable()
    {
        inputActions.player.Enable(); //오브젝트가 생성되면 입력을 받도록 활성화
        inputActions.player.Move.performed += OnMove;   //performed 일 때 OnMove 함수 실행하도록 연결
        inputActions.player.Move.canceled += OnMove;    //canceled 일 때 OnMove 함수 실행하도록 연결
        inputActions.player.Fire.started += Fire;
    }

    /// <summary>
    /// 이 스크립트가 들어있는 게임 오브젝트가 비활성화 되었을 때 호출
    /// </summary>
    private void OnDisable()
    {
        inputActions.player.Fire.started -= Fire;
        inputActions.player.Move.performed -= OnMove; //연결해 놓은 함수 해제(안전을 위해)
        inputActions.player.Move.canceled -= OnMove;  
        inputActions.player.Disable(); //오브젝트가 사라질 때 더이상 입력을 받지 않도록 비활성화
    }

    /// <summary>
    /// 시작할 때, 첫번째 Update 함수가 실행되기 직전에 호출
    /// </summary>
    private void Start()
    {
        
    }

    /// <summary>
    /// 매 프레임마다 호출
    /// </summary>
    private void Update()
    {
        transform.position += speed * dir * Time.deltaTime;
    }

    private void OnMove(InputAction.CallbackContext context)
    {
        //Exception : 예외 상황(무엇을 해야 할지 지정이 안되어있는 예외 일때(코드가 짜여지지 않은 상황))
        //throw new NotImplementedException();    //NotImplementedException(구현되지 않았음) 을 실행해라. => 코드 구현을 알려주기 위해 강제로 죽이는 코드

        Debug.Log("이동 입력");

        Vector2 Inputdir = context.ReadValue<Vector2>();
        dir = Inputdir;
    }

    public void Fire(InputAction.CallbackContext context)
    {
        Debug.Log("발사");
    }
}
