using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float turnSpeed = 540f;

    void Start()
    {
        //콘솔창에 입력됨
        Debug.Log("I am alive!");

    }

    // Update is called once per frame
    void Update()
    {

        //이동
        //좌우 방향키
        float front = Input.GetAxis("Horizontal");
        //위아래 방향키
        float updo = Input.GetAxis("Vertical");


        if (Input.GetKey(KeyCode.Q))
        {
            KeyDown_Q();
        }

        if (Input.GetKey(KeyCode.W))
        {
            KeyDown_W();
        }

        if (Input.GetKey(KeyCode.E))
        {
            KeyDown_E();
        }
        if (Input.GetKey(KeyCode.R))
        {
            KeyDown_R();
        }


        //transform.Translate (0f, 0f, h * moveSpeed * Time.deltaTime);

        //Move
        transform.Translate(0f, 0f, front * moveSpeed * Time.deltaTime);
        transform.Translate(0f, updo * moveSpeed * Time.deltaTime,0f);

        //Turn
        //transform.Rotate(0f, r1 * turnSpeed * Time.deltaTime, 0f);
    }
    private void KeyDown_Q()
    {
        //회전
        transform.Rotate(0f, 1 * turnSpeed * Time.deltaTime, 0f);
    }
    private void KeyDown_W()
    {
        //회전
        transform.Rotate(0f, -1 * turnSpeed * Time.deltaTime, 0f);
    }
    private void KeyDown_E()
    {
        //회전
        transform.Rotate(0f,0f, 1 * turnSpeed * Time.deltaTime);
    }
    private void KeyDown_R()
    {
        //회전
        transform.Rotate(0f,0f, -1 * turnSpeed * Time.deltaTime);
    }
}
