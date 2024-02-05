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
        // 버튼을 클릭하면 LoadScene 메서드 호출
        this.btn.onClick.AddListener(() => {
            LoadAppleCatchScene();
        });
    }

    void LoadAppleCatchScene()
    {
        Debug.Log("AppleCatch으로 전환");
        SceneManager.LoadScene("AppleCatch");
    }
}
