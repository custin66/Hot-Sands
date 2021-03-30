using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    private int forwardSpeed;

    [SerializeField]
    private int sideSpeed;


    void Update()
    {
        MovingForward();
        SideMovingControls();
    }
    void MovingForward()
    {
        transform.position += Vector3.forward * forwardSpeed*Time.deltaTime;
    }

    void SideMovingControls()
    {
        transform.position += new Vector3(Input.GetAxis("Horizontal") * sideSpeed*Time.deltaTime, 0f, 0f);
    }
}
