using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HumanScrollWheel : MonoBehaviour
{
    Animator Human;

    [SerializeField]
    float MoveSpeed = 0;

    [SerializeField]
    float speedMultiplier = 0.1f;

    void Start()
    {
        Human = GetComponent<Animator>();
    }

    void Update()
    {
        float scrollInput = Input.mouseScrollDelta.y;
        MoveSpeed += scrollInput * speedMultiplier;
        
        MoveSpeed = Mathf.Clamp(MoveSpeed, 0, 1);
        MoveSpeed = Mathf.Round(MoveSpeed * 10) / 10f;

        Human.SetFloat("Speed", MoveSpeed);
    }
}
