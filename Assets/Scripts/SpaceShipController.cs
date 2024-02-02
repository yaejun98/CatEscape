using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceShipController : MonoBehaviour
{
    [SerializeField] private float speed = 1f; // �̵� �ӵ�

    void Update()
    {
        // Ű���� �Է��� �޾� �̵� �� ȸ�� ó��
        Move();
    }

    void Move()
    {
        // �¿� Ű �Է� �ޱ�
        float horizontalInput = Input.GetAxis("Horizontal");
        // �յ� Ű �Է� �ޱ�   
        float verticalInput = Input.GetAxis("Vertical");
        // �̵� ���� ���
        //Vector2 translation = new Vector2(horizontalInput, verticalInput) * speed * Time.deltaTime;
        Vector2 inputVector = new Vector2(horizontalInput, verticalInput).normalized;
        Vector2 translation = inputVector * speed * Time.deltaTime;
        // ���� ��ġ�� �������� �̵�
        transform.Translate(translation, Space.World);

        // X ��ǥ ����
        Vector3 newPosition = transform.position;
        newPosition.x = Mathf.Clamp(newPosition.x, -2.64f,2.66f); // ���ϴ� �¿� ������ ����

        // Y ��ǥ ����
        newPosition.y = Mathf.Clamp(newPosition.y, -4.12f, 6.13f);

        // ���ο� ��ġ ����
        transform.position = newPosition;

        Debug.LogFormat("���� ��ǥ {0}", transform.position);
        //���ּ��� ȭ�鿡�������� ���� Destroy
    }
}
