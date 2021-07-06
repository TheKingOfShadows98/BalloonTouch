using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalloonController : MonoBehaviour
{
    void Awake(){
        transform.eulerAngles = new Vector3(0f, -90f, 0f);
        transform.localScale = new Vector3(0.3f, 0.3f, 0.3f);
    }

    private void OnEnable(){
        Invoke("Disable", 2f);
    }

    private void OnDisable(){
        Pooler.SINGLETON.AddToPool(gameObject);
    }

    void Disable(){
        gameObject.SetActive(false);
    }
}


