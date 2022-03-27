using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class TargetManager : GameBehaviour<TargetManager>
{
    public Transform[] spawnPoints;
    public GameObject[] targetTypes;
    public List<GameObject> targets;
    // Start is called before the first frame update
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            SpawnTargets();
        }
    }

    void SpawnTargets()
    {
        for (int i = 0; i < spawnPoints.Length; i++)
        {
            int rndTarget = Random.Range(0, targetTypes.Length);
            GameObject target = Instantiate(targetTypes[rndTarget], spawnPoints[i].position, spawnPoints[i].rotation);
            targets.Add(target);
        }
    }
}
