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
            //생성 
            GameObject go = UnityEngine.Object.Instantiate(this.bulletPrefab);
            //위치 재 설정 
            float randX = UnityEngine.Random.Range(-2.64f, 2.66f); 

            go.transform.position
                = new Vector3(randX, go.transform.position.y, go.transform.position.z);

            
        }
    }
}
