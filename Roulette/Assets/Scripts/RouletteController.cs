using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RouletteController : MonoBehaviour
{
    float rotSpeed;

    void Start()
    {

    }

    void Update()
    {
        bool isLeftButtonDown = Input.GetMouseButtonDown(0);
        bool isRightButtonDown = Input.GetMouseButtonDown(1);

        // 1. 화면을 누르면 어떻게 감지하지?
        if (isLeftButtonDown)
        {
            Debug.Log("Mouse Left Button Down");
            rotSpeed = 10;
        }
        else if (isRightButtonDown)
        {
            Debug.Log("Mouse Right Button Down");
            rotSpeed = -10;
        }

        // 2. 어떻게 회전시키지?
        this.transform.Rotate(0, 0, rotSpeed);

        // 3. 속도를 줄인다.
        rotSpeed *= 0.96f;

    }
}
