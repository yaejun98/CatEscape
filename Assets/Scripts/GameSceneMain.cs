using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameSceneMains : MonoBehaviour
{
    [SerializeField] private Text textHp;
    [SerializeField] private Button btnLoadScene;
    [SerializeField] private GameObject heroPrefab;
    void Start()
    {
        //��ư�� Ŭ���ϸ� ���ٹ��� ȣ��� 
        this.btnLoadScene.onClick.AddListener(() => {
            Debug.Log("VillageScene���� ��ȯ");
            SceneManager.LoadScene("VillageScene");
        });

        this.CreateHero();
    }

    private void CreateHero()
    {
        GameObject heroGo = Instantiate(this.heroPrefab);
        Debug.LogFormat("heroGo: {0}", heroGo);
        HeroController heroController = heroGo.GetComponent<HeroController>();
        //Debug.LogFormat("heroController: {0}", heroController);
        //Debug.LogFormat("heroController.onHit: {0}", heroController.onHit);
        heroController.onHit = () => {

            Debug.Log("������ ���ظ� �޾ҽ��ϴ�.");
            Debug.LogFormat("{0}/{1}", heroController.hp, heroController.maxHp );

        };
    }
}