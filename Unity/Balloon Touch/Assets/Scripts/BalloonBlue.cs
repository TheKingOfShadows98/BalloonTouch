using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalloonBlue : MonoBehaviour
{
    void Awake(){
        transform.eulerAngles = new Vector3(0f, -90f, 0f);
        transform.localScale = new Vector3(0.3f, 0.3f, 0.3f);
    }

    void Update(){
        Vector3 dir = Vector3.up;
        float speed = 4f * Time.deltaTime;

        transform.Translate(dir * speed);
    }

    private void OnEnable(){
        Invoke("Disable", 5f);
    }

    void Disable(){
        Pool.pooler.AddToPoolBlue(gameObject);
        
        gameObject.SetActive(false);
    }

    private void OnDisable(){
        CancelInvoke();
    }
}
        
