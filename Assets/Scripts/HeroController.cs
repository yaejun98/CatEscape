using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroController : MonoBehaviour
{
    public int maxHp = 10;
    public int hp;

    public System.Action onHit;

    private void Start()
    {
        this.hp = this.maxHp;
        //Debug.LogFormat("{0}/{1}", this.hp, this.maxHp);
    }

    void Update()
    {
        //ȭ���� Ŭ���ϸ� ���ظ� �޴´� 
        if (Input.GetMouseButtonDown(0))
        {
            this.hp -= 1;
            if (this.hp <= 0) this.hp = 0;
            //Debug.LogFormat("{0}/{1}", this.hp, this.maxHp);

            this.onHit();   //�븮�� ȣ�� 
        }
    }
}