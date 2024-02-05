using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test2Main : MonoBehaviour
{
    [SerializeField] private Transform basketTransform;

    void Update()
    {
        //ȭ���� Ŭ���ϸ� 
        if (Input.GetMouseButtonDown(0))
        {
            //�ȼ� ��ǥ�� ������ ����ȿ��� ���� ��ü�� ����� 
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            //���� ��ü�� �������ִ¼Ӽ� 
            // ray.origin : ���� ��ġ 
            // ray.direction : ���� 
            //������ ���� ���� 
            //������ġ    ����         ����    ���ʵ��� �����ٷ�
            Debug.DrawRay(ray.origin, ray.direction * 20f, Color.red, 10);

            // ���̿� �ݶ��̴� �浹 üũ 
            RaycastHit hit; //�浹 �ߴٸ� �浹 ������ ��� ���� 

            if (Physics.Raycast(ray.origin, ray.direction, out hit, 20))
            {
                //���̿� �ݶ��̴��� �浹 �ߴ�
                Debug.Log("�浹��");
                Debug.LogFormat("=> {0}", hit.point); //�浹 ������ġ (������ġ)
                //this.cubeTransform.position = hit.point;

                int x = Mathf.RoundToInt(hit.point.x);
                int z = Mathf.RoundToInt(hit.point.z);
                Debug.LogFormat("=> {0}", new Vector3(x, hit.point.y, z));

                basketTransform.position = new Vector3(x, hit.point.y, z);
            }

        }
    }
}
