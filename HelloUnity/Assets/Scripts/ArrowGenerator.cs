using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ArrowGenerator : MonoBehaviour
{
    //������ ������ ������ ������ �ν��Ͻ��� ����� 
    [SerializeField] private GameObject arrowPrefab;
    private float delta;    //����� �ð� ���� 

    void Update()
    {
        delta += Time.deltaTime;  //���� �����Ӱ� ���� ������ ���� �ð� 
        Debug.Log(delta);
        if (delta > 3)  //3�ʺ��� ũ�ٸ� 
        {
            //���� 
            GameObject go = UnityEngine.Object.Instantiate(this.arrowPrefab);
            //��ġ �� ���� 
            float randX = UnityEngine.Random.Range(-10, 10); //-8 ~ 8

            go.transform.position 
                = new Vector3(randX, go.transform.position.y, go.transform.position.z);

            delta = 0;  //��� �ð��� �ʱ�ȭ 
        }
    }
}