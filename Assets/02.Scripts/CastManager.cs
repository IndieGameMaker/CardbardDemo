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

        if (Physics.Raycast(ray, out hit, distance, 1<<8)) //1<<8 = 2^8 = 256
        {
            Debug.Log("Hit = " + hit.transform.name);
            MoveCtrl.isStopped = true;
        }
        else
        {
            MoveCtrl.isStopped = false;
        }
    }
}
