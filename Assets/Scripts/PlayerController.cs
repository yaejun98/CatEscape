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

        //람다함수 이용
        this.btnLeft.onClick.AddListener(() =>
        {
            Debug.Log("왼쪽 화살표 버튼 클릭");
            this.transform.Translate(-2, 0, 0);
        });


        this.btnRight.onClick.AddListener(() =>
        {
            Debug.Log("오른쪽 화살표 버튼 클릭");
            this.transform.Translate(2, 0, 0);

        });

    }

    void Update()
    {
        //키보드 입력을 받는 코드 작성
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            Debug.Log("왼쪽으로 2유닛만큼 이동");
            //x축으로 -2만큼 이동
            this.transform.Translate(-2, 0, 0);
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            Debug.Log("오른쪽으로 2유닛만큼 이동");
            //x축으로 2만큼 이동
            this.transform.Translate(2, 0, 0);
        }

    }
    // 이벤트 함수
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(this.transform.position, this.radius);
    }

    public void LeftButtonClick()
    {
        Debug.Log("Left button click");
    }

    public void RightButtonClick()
    {
        Debug.Log("Right button click");

    }

}
