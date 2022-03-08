using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerPad : MonoBehaviour
{
    public GameObject sphere;
    public Color toColor;
    Color originalColor;

    private void Start()
    {
        originalColor = sphere.GetComponent<Renderer>().material.color;
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            sphere.GetComponent<Renderer>().material.color = toColor;
        }
    }

    void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            sphere.transform.localScale += Vector3.one * 0.01f;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            sphere.GetComponent<Renderer>().material.color = originalColor;
            sphere.transform.localScale = Vector3.one;
        }
    }
}

