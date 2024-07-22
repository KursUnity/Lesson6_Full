using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DistanceChecker : MonoBehaviour
{
    public Transform target; // Цель
    public float checkDistance = 5f; // Дистанция

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
        float distance = Vector3.Distance(transform.position, target.position); // в переменную distance (float) записываются данные от нашего расстояния до цели
        // наше расстояние это - объект на котором находится данный скрипт

        return distance <= checkDistance; // Возвращет true - если дистанция меньше переменной checkDistance
    }
}
