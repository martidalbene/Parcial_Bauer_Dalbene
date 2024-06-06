using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HighPoints : MonoBehaviour
{
    public CameraMovement view;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            view.onPoint = true;
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            view.onPoint = false;
        }
    }
}
