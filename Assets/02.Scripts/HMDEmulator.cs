using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HMDEmulator : MonoBehaviour
{
    private Transform camTr;

    public float yawSpeed = 3.0f;   //Y축 회전 속도
    public float pitchSpeed = 3.0f; //X축 회전 속도

    // Start is called before the first frame update
    void Start()
    {
        camTr = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update() //60fps  1/60 sec 발생 빈도 불규칙
    {
        if (Input.GetKey(KeyCode.LeftAlt))  //GetKeyDown, GetKeyUp
        {
            Debug.Log("LeftAlt pressed !!!");
        }
    }

}
