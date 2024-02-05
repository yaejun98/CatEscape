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

            if (itemCreate == 0)
            {
                GameObject appleGo = Object.Instantiate(this.applePrefab);
                float appleRandX = UnityEngine.Mathf.RoundToInt(Random.Range(-1.5f, 1.5f));
                float appleRandZ = UnityEngine.Mathf.RoundToInt(Random.Range(-1.5f, 1.5f));
                appleGo.transform.position
                    = new Vector3(appleRandX, appleGo.transform.position.y, appleRandZ);
            }
            else if (itemCreate == 1)
            {
                GameObject bombGo = Object.Instantiate(this.bombPrefab);
                float bombRandX = UnityEngine.Mathf.RoundToInt(Random.Range(-1.5f, 1.5f));
                float bombRandZ = UnityEngine.Mathf.RoundToInt(Random.Range(-1.5f, 1.5f));
                bombGo.transform.position
                    = new Vector3(bombRandX, bombGo.transform.position.y, bombRandZ);
            }
            delta = 0;
        }
     
    }
}
