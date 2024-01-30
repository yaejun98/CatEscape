using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController2 : MonoBehaviour
{
    public float radius = 1f;

    private void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            Debug.Log("¿ÞÂÊ");
            this.transform.Translate(-2, 0, 0);
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            Debug.Log("¿À¸¥ÂÊ");
            this.transform.Translate(2, 0, 0);

        }
    }
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(this.transform.position, this.radius);

    }
}
