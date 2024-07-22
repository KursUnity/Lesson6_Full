using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DistanceChecker : MonoBehaviour
{
    public Transform target; // ����
    public float checkDistance = 5f; // ���������

    void Update()
    {
        if (isTargetClose())
        {
            Debug.Log("Target is within range!");
        }
        else
        {
            Debug.Log("Target is out of range");
        }
    }

    bool isTargetClose()
    {
        float distance = Vector3.Distance(transform.position, target.position); // � ���������� distance (float) ������������ ������ �� ������ ���������� �� ����
        // ���� ���������� ��� - ������ �� ������� ��������� ������ ������

        return distance <= checkDistance; // ��������� true - ���� ��������� ������ ���������� checkDistance
    }
}
