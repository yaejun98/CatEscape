using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters;
using Unity.VisualScripting;
using UnityEngine;

public class ItemGenerator : MonoBehaviour
{
    [SerializeField] private GameObject applePrefab;
    [SerializeField] private GameObject bombPrefab;
    private float delta;
    private int itemCreate;

    void Update()
    {
        delta += Time.deltaTime;
        itemCreate = Mathf.RoundToInt(Random.Range(0f, 1f));
        if (delta > 3)
        {
            float RandX = UnityEngine.Mathf.RoundToInt(Random.Range(-1.5f, 1.5f));
            float RandZ = UnityEngine.Mathf.RoundToInt(Random.Range(-1.5f, 1.5f));
            if (itemCreate == 0)
            {
                
                GameObject appleGo = Object.Instantiate(this.applePrefab);
                
                appleGo.transform.position
                    = new Vector3(RandX, appleGo.transform.position.y, RandZ);
            }
            else if (itemCreate == 1)
            {
                GameObject bombGo = Object.Instantiate(this.bombPrefab);
                
                bombGo.transform.position
                    = new Vector3(RandX, bombGo.transform.position.y,RandZ);
            }
            delta = 0;
        }
     
    }
}
