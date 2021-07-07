using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public float result = 0f;
    public bool spawn;
    public float xPos;
    
    void Start(){
        spawn = true;
    }

    void Awake(){
        InvokeRepeating("SpawnResult", 0f, 2f);
    }

    void Update()
    {
        result = Random.Range(0f, 5f);
        xPos = Random.Range(-1.6f, 1.6f);

        Debug.Log(result);

        //SpawnResult();
    }

    public void SpawnResult(){
        GameObject redBalloon = Pool.pooler.GetRedObject();

        if(result < 1f && spawn != false){
         //if(redBalloon == null) return;

         redBalloon.transform.position = new Vector3(xPos, -5f, 0f);
         redBalloon.SetActive(true);
        }

        GameObject blueBalloon = Pool.pooler.GetBlueObject();

        if(result > 4f && result < 6f && spawn != false){
         //if(blueBalloon == null) return;

         blueBalloon.transform.position = new Vector3(xPos, -5f, 0f);
         blueBalloon.SetActive(true);
        }
 }
}        


         


    



        


