using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleBoolScript : MonoBehaviour
{
    Animator Cube;

    // Start is called before the first frame update
    void Start()
    {
        Cube = gameObject.GetComponent<Animator>();
    }

    void Toggle()
    {
        if (!Cube.GetBool("ToggleIdle"))
        {
            Cube.SetBool("ToggleIdle", true);
        }
        else if (Cube.GetBool("ToggleIdle"))
        {
            Cube.SetBool("ToggleIdle", false);
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            Toggle();
        }
    }
}