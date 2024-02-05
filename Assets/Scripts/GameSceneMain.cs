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
        //버튼을 클릭하면 람다문이 호출됨 
        this.btnLoadScene.onClick.AddListener(() => {
            Debug.Log("VillageScene으로 전환");
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

            Debug.Log("영웅이 피해를 받았습니다.");
            Debug.LogFormat("{0}/{1}", heroController.hp, heroController.maxHp );

        };
    }
}