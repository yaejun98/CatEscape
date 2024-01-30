using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowController2 : MonoBehaviour
{
    [SerializeField] private float speed = 1f;
    [SerializeField] private float radius = 1f;
    
    private GameObject playerGo;

    private void Start()
    {
        this.playerGo = GameObject.Find("player");
    }


    void Update()
    {
        Vector3 movement = Vector3.down * speed * Time.deltaTime;
        this.transform.Translate(movement);
        Debug.LogFormat("y : {0}", this.transform.position.y);
        if(this.transform.position.y <= -3.43f)
        {
            //Destroy(this);  // ArrowController ������Ʈ�� ���� �ȴ�.
            Destroy(this.gameObject);
        }
        // �Ÿ� ���
        Vector2 p1 = this.transform.position; // ȭ�� ��ġ
        Vector2 p2 = this.playerGo.transform.position; // ������� ��ġ
        // ����
        Vector2 dir = p1 - p2;
        // �Ÿ�
        float distance2 = dir.magnitude;
        // �Ÿ��� ���ҰŸ� float distance = Vector2.Distance(p1, p2);

        float r3 = this.radius;

        PlayerController2 controller = this.playerGo.GetComponent<PlayerController2>();
        float r4 = controller.radius;

        float sumRadius2 = r3 + r4;

        if(distance2 < sumRadius2) // �浹
        {
            Debug.LogFormat("�浹�� : {0}, {1}", distance2, sumRadius2);
            Destroy(this.gameObject);
        }
    }
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(this.transform.position, this.radius);

    }
}
