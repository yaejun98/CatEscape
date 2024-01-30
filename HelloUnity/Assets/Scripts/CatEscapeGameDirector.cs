using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CatEscapeGameDirector : MonoBehaviour
{
    [SerializeField] private Image hpGauge;
    public void DecreaseHp()
    {
        this.hpGauge.fillAmount -= 0.1f; //10 퍼센트씩 감소
    }
}
