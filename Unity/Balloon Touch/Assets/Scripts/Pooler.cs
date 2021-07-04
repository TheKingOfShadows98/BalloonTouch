using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pooler : MonoBehaviour
{
    public static Pooler SINGLETON;
    public GameObject rBalloon;
    public GameObject bBalloon;
    public GameObject yBalloon;
    public GameObject gBalloon;
    int count = 1;

    public List <GameObject> poolBalloon = new List <GameObject>();

    void Awake(){
        SINGLETON = this;
    }

    void Start(){
        InitPool();
    }

    void InitPool(){
        for(int i = 0; i < count; i++){

            GameObject red = Instantiate(rBalloon);
            red.SetActive(true);
            poolBalloon.Add(red);

            GameObject blue = Instantiate(bBalloon);
            blue.SetActive(true);
            blue.SetActive(true);
            poolBalloon.Add(blue);
        }
    }

    void CreateObject(){
        GameObject red = Instantiate(rBalloon);
        red.SetActive(true);
        GameObject blue = Instantiate(rBalloon);
        blue.SetActive(true);
        
        AddToPool(red, blue);
    }

    void GetPooledObject(){
        GameObject red;
        GameObject blue;

        if(poolBalloon.Count < 1){
            CreateObject();
        }
        else{
            red = poolBalloon[0];
            poolBalloon.Remove(red);
            blue = poolBalloon[0];
            poolBalloon.Remove(blue);
        }
    }

    public void AddToPool(GameObject red, GameObject blue){
        poolBalloon.Add(red);
        poolBalloon.Add(blue);
    }
}
        


