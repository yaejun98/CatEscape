using System.Collections;
using System.Collections.Generic;
<<<<<<< HEAD
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
public class PlayerController : MonoBehaviour
{
    [SerializeField] private Button btnLeft;
    [SerializeField] private Button btnRight;

    public float radius = 1f;
    private void Start()
    {
        //this.btnLeft.onClick.AddListener(this.LeftButtonClick);
        //this.btnRight.onClick.AddListener(this.RightButtonClick);

        //�����Լ� �̿�
        this.btnLeft.onClick.AddListener(() =>
        {
            Debug.Log("���� ȭ��ǥ ��ư Ŭ��");
            this.transform.Translate(-2, 0, 0);
        });
        { }
        this.btnRight.onClick.AddListener(() =>
        {
            Debug.Log("������ ȭ��ǥ ��ư Ŭ��");
            this.transform.Translate(2, 0, 0);

        });

    }

=======
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float radius = 1f;  
    void Start()
    {
        
    }
    
>>>>>>> 89f664848369ee40366ef2a797bf9b501034bebc
    void Update()
    {
        //Ű���� �Է��� �޴� �ڵ� �ۼ�
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            Debug.Log("�������� 2���ָ�ŭ �̵�");
            //x������ -2��ŭ �̵�
            this.transform.Translate(-2, 0, 0);
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            Debug.Log("���������� 2���ָ�ŭ �̵�");
            //x������ 2��ŭ �̵�
            this.transform.Translate(2, 0, 0);
        }
<<<<<<< HEAD

=======
       
>>>>>>> 89f664848369ee40366ef2a797bf9b501034bebc
    }
    // �̺�Ʈ �Լ�
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(this.transform.position, this.radius);
    }

<<<<<<< HEAD
    public void LeftButtonClick()
    {
        Debug.Log("Left button click");
    }

    public void RightButtonClick()
    {
        Debug.Log("Right button click");

    }

=======
>>>>>>> 89f664848369ee40366ef2a797bf9b501034bebc
}
