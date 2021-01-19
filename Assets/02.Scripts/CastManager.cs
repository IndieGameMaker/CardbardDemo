using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CastManager : MonoBehaviour
{
    private Ray ray;
    private RaycastHit hit;

    private Transform camTr;

    [Range(5.0f, 20.0f)]
    public float distance = 10.0f;

    //바라본 객체를 저장할 변수
    private GameObject lookObject = null;

    // Start is called before the first frame update
    void Start()
    {
        camTr = Camera.main.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        ray = new Ray(camTr.position, camTr.forward);
        Debug.DrawRay(ray.origin, ray.direction * distance, Color.green);

        if (Physics.Raycast(ray, out hit, distance, 1<<8 | 1<<9)) //1<<8 = 2^8 = 256
        {
            MoveCtrl.isStopped = true;
        }
        else
        {
            MoveCtrl.isStopped = false;
        }


        if (Physics.Raycast(ray, out hit, distance, 1<<9))
        {
            //이전에 응시했던 버튼과 다른 버튼일 경우 (새로운 버튼을 응시했을때)
            

            //이전에 응시했던 버튼 PointerExit 이벤트
            //새로 응시한 버튼 PointerEnter 이벤트
        }
    }
}
