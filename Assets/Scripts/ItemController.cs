using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class ItemController : MonoBehaviour
{
    [SerializeField] float moveSpeed = 1f;
    // Update is called once per frame
    void Update()
    {
        this.transform.Translate(Vector3.down * moveSpeed * Time.deltaTime);
        // y���� ���� 0�� ���ų� �������(�ٴڿ� ������)
        if(this.transform.position.y <= 0)
        {
            Destroy(this.gameObject);// ������ ����
        }
        
    }
  
}
