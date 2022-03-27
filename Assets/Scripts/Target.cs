using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : GameBehaviour
{
    float moveDistance = 500;
    public Difficulty difficulty;
    
    float scaleFactor = 1;
    
    // Start is called before the first frame update
    void Start()
    {
        Setup();
        transform.localScale = Vector3.one * scaleFactor;
        StartCoroutine(Move());
    }

    void Setup()
    {
        switch(difficulty)
        {
            case Difficulty.Easy:
                scaleFactor = 1;
                break;
            case Difficulty.Medium:
                scaleFactor = 2;
                break;
            case Difficulty.Hard:
                scaleFactor = 3;
                break;
            default:
                scaleFactor = 1;
                break;
        }
    }

    IEnumerator Move()
    {
        for (int i = 0; i < moveDistance; i++)
        {
            transform.Translate(Vector3.forward * Time.deltaTime);
            yield return null;
        }
        transform.Rotate(Vector3.up * 180);
        yield return new WaitForSeconds(3);
        StartCoroutine(Move());
    }
}
