using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//��� Ŭ����
public class App : MonoBehaviour // new ������Ʈ ���̱�
{
    [SerializeField] private Transform b; // child
    private void Start()
    {
        Debug.LogFormat("b.position: {0}", b.position); //world space
        Debug.LogFormat("b.position: {0}", b.localPosition); // local space

    }
    // �� �����Ӹ��� ȣ���
    private void Update()
    {   
    }

}
