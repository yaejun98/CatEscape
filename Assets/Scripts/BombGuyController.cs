using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombGuyController : MonoBehaviour
{
    //BombGuyController가 Animator 컴포넌트를 알아야한다
    //왜? 애니메이션 전환을 해야 해서
    //Animator 컴포넌트는 자식 오브젝트 anim에 붙어 있다
    //어떻게 하면 자식오브젝트에 붙어 있는 Animator 컴포넌트를 가져올 수 있을까
    [SerializeField] private Animator anim;
    
    private void Start()
    {
        this.anim.SetInteger("State", 0);
        // [SerializeField] Animator anim; 를 쓰지 않는다면

        //Transform animTransform = this.transform.Find("anim");
        //GameObject animGo = animTransform.gameObject;
        //this.anim = animGo.GetComponent<Animator>();

        //코루틴 함수 호출시
        //this.StartCoroutine(this.CoMove());
    }

    //IEnumerator CoMove()
    //{
    //    //매 프레임마다 앞으로 이동
    //    while (true)
    //    {
    //        this.transform.Translate(transform.right * 1f * Time.deltaTime);
    //        yield return null; //다음 프레임으로 넘어간다 => while문 안에 들어가야 함
    //    }
    //}

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha0))
            //Alpha+num 은 키보드 위에 숫자버튼
            //Keypad+num 은 키보드 우측 숫자버튼
        {
            Debug.Log("Idle");
            //애니메이션 전환 하기
            //전환 할 때 파라미터에 값을 변경하기
            this.anim.SetInteger("State", 0);

        }
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            Debug.Log("Run");
            this.anim.SetInteger("State", 1);

        }

    }
}
