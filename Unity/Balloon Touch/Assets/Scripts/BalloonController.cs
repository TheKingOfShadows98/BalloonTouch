using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalloonController : MonoBehaviour
{
    void Awake(){
        transform.eulerAngles = new Vector3(0f, -90f, 0f);
        transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
    }
}

