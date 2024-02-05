using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleCatchGameDirector : MonoBehaviour
{
    [SerializeField] private float score;
    public void addPoint()
    {
        this.score = score + 100;
    }
    public void decreasePoint()
    {
        this.score = score - 100;
    }
}
