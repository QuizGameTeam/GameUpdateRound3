using System.Collections.Generic;
using System.Collections;
using UnityEngine;

public class HintPop : MonoBehaviour
{
    public GameObject mess;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Player")
        {
            mess.SetActive(true);
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if(other.gameObject.tag == "Player")
        {
            mess.SetActive(false);
        }
    }
}