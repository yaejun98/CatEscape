using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CarController : MonoBehaviour
{
    [SerializeField] private float maxSpeed = 0.1f;
    [SerializeField] private float attenuation = 0.96f;
    [SerializeField] private float divied = 500f; 
    private float speed = 0;
    private Vector3 startPosition; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // 왼쪽 버튼을 눌렀따면
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("화면 터치 시작");
            // 화면을 터치한 위치 가져오기
            Debug.Log(Input.mousePosition);
            this.startPosition = Input.mousePosition;
           // speed = maxSpeed;   
        }

        else if (Input.GetMouseButtonUp(0))
        {
            Debug.Log("화면에서 손을 뗌");
            Debug.Log(Input.mousePosition);
            float length = Input.mousePosition.x - this.startPosition.x;
            Debug.Log(length);
            Debug.Log(length / divied);
            speed = length / divied;
            Debug.LogFormat("<color=yellow>speed : {0}</color>", speed);

            // 화면에서 손을 뗀 지점.x - 터치한 지점의 x

            //사운드 실행

            //게임 오브젝트에 붙어 있는 컴포넌트 가져오기
            AudioSource audioSource = this.gameObject.GetComponent<AudioSource>();
            audioSource.Play(); //인스턴스 메서드


        }
        // 0.1 유닛씩 매 프레임마다 이동한다
        this.gameObject.transform.Translate(new Vector3(speed, 0, 0));
        //매 프레임마다 스피드를 감속 한다.
        speed *= attenuation;
    }
}
