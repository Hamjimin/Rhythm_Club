using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    TimingManager thetimingManager;

    private void Start()
    {
        thetimingManager = FindObjectOfType<TimingManager>();
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            thetimingManager.CheckTiming();
        }
        else if (Input.GetKeyDown(KeyCode.Space))
        {
            thetimingManager.CheckTiming2();
        }
    }
}
