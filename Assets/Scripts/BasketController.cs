using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class BasketController : MonoBehaviour
   

{
    [SerializeField] private AudioClip appleSfx;
    [SerializeField] private AudioClip bombSfx;

    private AudioSource audioSource;
    private AppleCatchGameDirector gameDirector;
    private void Start()
    {
        this.audioSource = this.GetComponent<AudioSource>();
        this.gameDirector = FindObjectOfType<AppleCatchGameDirector>();
    }

    void Update()
    {
        //ȭ���� ��ġ�ϸ� ��ġ�� ��ġ�� �ٽ����� �����δ�.

        //ȭ���� ��ġ�ϸ� (Ŭ���ϸ�)
        if(Input.GetMouseButtonDown(0))
        {
            
            //Ray�� �����
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            //�������� RaycastHit hit ����
            RaycastHit hit;
            
            //if�� �ۼ� Physics.Raycast�� ���̶� �ݶ��̴��� �浹�ÿ��� true��ȯ
            if(Physics.Raycast(ray.origin, ray.direction, out hit, 20f))
            {
                // ���̿� �ݶ��̴��� �浹 �ߴٸ�
                // �ٱ����� ��ġ�� �����δ�.
                int x = Mathf.RoundToInt(hit.point.x);
                int z = Mathf.RoundToInt(hit.point.z);
                this.transform.position = new Vector3(x, 0, z);
            }
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        Debug.LogFormat("��Ҵ� => {0}", other.gameObject.tag);
        
        if(other.gameObject.tag == "Apple")
        {
            Debug.Log("����");
            this.audioSource.PlayOneShot(this.appleSfx); // �ѹ��� �����Ѵ�.
            Destroy(other.gameObject);
            gameDirector.AddScore();
        }
        else if(other.gameObject.tag == "Bomb")
        {
            Debug.Log("����");
            this.audioSource.PlayOneShot(this.bombSfx);
            Destroy(other.gameObject);
            gameDirector.DecreaseScore();
        }

        gameDirector.GameOver();
        
    }
}
