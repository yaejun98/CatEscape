using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameDirector : MonoBehaviour
{
    private GameObject carGo;
    private GameObject flagGo;
    private GameObject distanceGo;
    private Text distanceText;



    // Start is called before the first frame update
    void Start()
    {
        this.carGo = GameObject.Find("car"); // �����޼���
        Debug.LogFormat("this.carGo: {0}", this.carGo); // car ���ӿ�����Ʈ �ν��Ͻ�
        this.flagGo = GameObject.Find("flag");
        Debug.LogFormat("this.flagGo: {0}", this.flagGo); // flag ���ӿ�����Ʈ �ν��Ͻ�
        this.distanceGo = GameObject.Find("distance");
        Debug.LogFormat("this.distnaceGo: {0}", this.distanceGo); // distance ���� ������Ʈ �ν��Ͻ�

        distanceText=this.distanceGo.GetComponent<Text>();
        Debug.LogFormat("distanceText: {0}", distanceText);
       

    }

    // Update is called once per frame
    void Update()
    {
        // �������Ӹ��� �ڵ����� ����� �Ÿ��� ���
        float length = this.flagGo.transform.position.x - this.carGo.transform.position.x;
        Debug.Log(length);
        
        this.distanceText.text = "Distance: " + length.ToString("F2");
        Debug.Log(distanceText.text);
    }
}
