using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_Button : MonoBehaviour
{
    void OnGazeEnter()
    {
        Debug.Log("Enter !!!");
    }

    void OnGazeExit()
    {
        Debug.Log("Exit !!!");
    }
}
