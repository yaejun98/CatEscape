using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombGuyController : MonoBehaviour
{
    //BombGuyController�� Animator ������Ʈ�� �˾ƾ��Ѵ�
    //��? �ִϸ��̼� ��ȯ�� �ؾ� �ؼ�
    //Animator ������Ʈ�� �ڽ� ������Ʈ anim�� �پ� �ִ�
    //��� �ϸ� �ڽĿ�����Ʈ�� �پ� �ִ� Animator ������Ʈ�� ������ �� ������
    [SerializeField] private Animator anim;
    
    private void Start()
    {
        this.anim.SetInteger("State", 0);
        // [SerializeField] Animator anim; �� ���� �ʴ´ٸ�

        //Transform animTransform = this.transform.Find("anim");
        //GameObject animGo = animTransform.gameObject;
        //this.anim = animGo.GetComponent<Animator>();

        //�ڷ�ƾ �Լ� ȣ���
        //this.StartCoroutine(this.CoMove());
    }

    //IEnumerator CoMove()
    //{
    //    //�� �����Ӹ��� ������ �̵�
    //    while (true)
    //    {
    //        this.transform.Translate(transform.right * 1f * Time.deltaTime);
    //        yield return null; //���� ���������� �Ѿ�� => while�� �ȿ� ���� ��
    //    }
    //}

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha0))
            //Alpha+num �� Ű���� ���� ���ڹ�ư
            //Keypad+num �� Ű���� ���� ���ڹ�ư
        {
            Debug.Log("Idle");
            //�ִϸ��̼� ��ȯ �ϱ�
            //��ȯ �� �� �Ķ���Ϳ� ���� �����ϱ�
            this.anim.SetInteger("State", 0);

        }
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            Debug.Log("Run");
            this.anim.SetInteger("State", 1);

        }

    }
}
