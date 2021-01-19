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
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
