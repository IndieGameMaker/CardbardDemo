using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCtrl : MonoBehaviour
{
    public Transform camTr; //메인카메라의 Transform 컴포넌트를 저장할 변수
    public float moveSpeed = 0.8f;

    private Transform tr;   //자신의 Transform 컴포넌트를 저장할 변수
    private CharacterController cc; //이동처리를 위한 컴포너트

    public static bool isStopped = false;

    void Start()
    {
        tr = GetComponent<Transform>();
        cc = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isStopped == true) return;

        Vector3 dir = camTr.forward;

        cc.SimpleMove(dir * moveSpeed);
    }
}
