using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletGenerator : MonoBehaviour
{
    [SerializeField] private GameObject bulletPrefab;


    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Space))  
        {
            //���� 
            GameObject go = UnityEngine.Object.Instantiate(this.bulletPrefab);
            //��ġ �� ���� 
            float randX = UnityEngine.Random.Range(-2.64f, 2.66f); 

            go.transform.position
                = new Vector3(randX, go.transform.position.y, go.transform.position.z);

            
        }
    }
}
