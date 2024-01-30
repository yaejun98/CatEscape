using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ArrowController : MonoBehaviour
{
    public float speed = 1f;
    [SerializeField] private float radius =0.5f;
    //[SerializeField] private GameObject playerGo;
    private GameObject playerGo;
    //�������� �����Ǵ� �ִ� ���� �ִ°� assign �Ҽ� ����.
    [Serialize] private CatEscapeGameDirector gameDirector;
    void Start()
    {
        //�̸����� ���ӿ�����Ʈ�� ã�´�.
        this.playerGo = GameObject.Find("player");
        // Ÿ������ ������Ʈ�� ã�´�
        this.gameDirector = GameObject.FindObjectOfType<CatEscapeGameDirector>();
    }

    // Update is called once per frame
    void Update()
    {
        //����*�ӵ�*�ð�
        Vector3 movement = Vector3.down * 1 * Time.deltaTime;
        this.transform.Translate(movement);
        //Debug.LogFormat("y : {0}", this.transform.position.y); // ȭ��ǥ�� ��ġ ���
        // ���� y��ǥ�� -3.5���� �۾������� ������ ����
        if (this.transform.position.y <= -3.5f)
        {
            //Debug.Log("����");
            //Destroy(gameObject); => ArrowController ������Ʈ�� ���ŵȴ�.
            Destroy(this.gameObject); //���ӿ�����Ʈ�� ������ ����
        }

        // �Ÿ� ���
        Vector2 p1 = this.transform.position;
        Vector2 p2 = this.playerGo.transform.position;
        Vector2 dir = p1 - p2; // ����
        float distance = dir.magnitude; //�Ÿ�
        // float distance = Vector2.Distance(p1, p2); => ������ �ʿ���� ��

        float r1 = this.radius;
        float r2 = this.playerGo.GetComponent<PlayerController>().radius;
        float sumRadius = r1 + r2;
        if(distance < sumRadius){
            Debug.LogFormat("�浹��: {0}, {1}", distance, sumRadius);
            Destroy(this.gameObject);

            this.gameDirector.DecreaseHp();
        }
    }
       
    // �̺�Ʈ �Լ�
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(this.transform.position, this.radius);
    }

}
