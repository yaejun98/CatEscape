using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameSceneMain : MonoBehaviour
{
    [SerializeField] private Button btn;

    void Start()
    {
        //��ư�� Ŭ���ϸ� ���ٹ��� ȣ��� 
        this.btn.onClick.AddListener(() => {
            Debug.Log("AppleCatch���� ��ȯ");
        });
        SceneManager.LoadScene("AppleCatch");
    }
}