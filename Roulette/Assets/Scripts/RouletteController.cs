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

        // 1. ȭ���� ������ ��� ��������?
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

        // 2. ��� ȸ����Ű��?
        this.transform.Rotate(0, 0, rotSpeed);

        // 3. �ӵ��� ���δ�.
        rotSpeed *= 0.96f;

    }
}
