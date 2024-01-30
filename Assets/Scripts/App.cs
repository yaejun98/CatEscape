using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//모노 클래스
public class App : MonoBehaviour // new 컴포먼트 붙이기
{
    [SerializeField] private Transform b; // child
    private void Start()
    {
        Debug.LogFormat("b.position: {0}", b.position); //world space
        Debug.LogFormat("b.position: {0}", b.localPosition); // local space

    }
    // 매 프레임마다 호출됨
    private void Update()
    {   
    }

}
