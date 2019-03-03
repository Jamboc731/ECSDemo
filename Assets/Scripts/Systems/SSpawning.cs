using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Entities;
using UnityEngine.UI;

public class SSpawning : ComponentSystem
{

    [SerializeField] Text countText;
    int count = 0;
    float currentPoint = 0;
    Vector3 [] spawns;

    struct Spawners
    {
        public CSpawning SpawnComponent;
    }

    protected override void OnStartRunning ()
    {
        base.OnStartRunning ();
        countText = GameObject.Find ("CountText").GetComponent<Text>();
    }

    protected override void OnUpdate ()
    {
        Debug.Log (currentPoint);
        if(currentPoint >= 1)
        {
            currentPoint = 0;
            foreach (var e in GetEntities<Spawners>())
            {
                count = 0;
                spawns = e.SpawnComponent.GetSpawns ();
                for (int i = 0; i < spawns.Length; i++)
                {
                    e.SpawnComponent.SpawnCube (spawns [i]);
                    count++;
                }

            }
            countText.text = (int.Parse(countText.text) + count).ToString();
        }
        currentPoint += Time.deltaTime;

    }
}
