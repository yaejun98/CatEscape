using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClimbCloudGameDirector : MonoBehaviour
{
    [SerializeField] private Text velocityText;

    public void UpdateVelocityText(Vector2 velocity)
    {
        float velocityX = Mathf.Abs(velocity.x);
        this.velocityText.text = velocityX.ToString();
    }
}