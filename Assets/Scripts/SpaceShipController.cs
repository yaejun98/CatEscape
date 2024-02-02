using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceShipController : MonoBehaviour
{
    [SerializeField] private float speed = 1f; // 이동 속도

    void Update()
    {
        // 키보드 입력을 받아 이동 및 회전 처리
        Move();
    }

    void Move()
    {
        // 좌우 키 입력 받기
        float horizontalInput = Input.GetAxis("Horizontal");
        // 앞뒤 키 입력 받기   
        float verticalInput = Input.GetAxis("Vertical");
        // 이동 벡터 계산
        //Vector2 translation = new Vector2(horizontalInput, verticalInput) * speed * Time.deltaTime;
        Vector2 inputVector = new Vector2(horizontalInput, verticalInput).normalized;
        Vector2 translation = inputVector * speed * Time.deltaTime;
        // 현재 위치를 기준으로 이동
        transform.Translate(translation, Space.World);

        // X 좌표 제한
        Vector3 newPosition = transform.position;
        newPosition.x = Mathf.Clamp(newPosition.x, -2.64f,2.66f); // 원하는 좌우 범위로 수정

        // Y 좌표 제한
        newPosition.y = Mathf.Clamp(newPosition.y, -4.12f, 6.13f);

        // 새로운 위치 적용
        transform.position = newPosition;

        Debug.LogFormat("현재 좌표 {0}", transform.position);
        //우주선이 화면에서나가면 제거 Destroy
    }
}
