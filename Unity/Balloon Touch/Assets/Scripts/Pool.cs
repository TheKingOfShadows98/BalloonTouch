using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pool : MonoBehaviour
{
    public static Pool pooler;
    public GameObject rBalloon;
    public GameObject bBalloon;
    public int amount = 1;

    public List <GameObject> RedPooler = new List <GameObject>();
    public List <GameObject> BluePooler = new List <GameObject>();

    void Awake(){
        pooler = this;
    }

    void Start(){
        InitPool();
    }
    
    public void InitPool(){
        GameObject red;
        GameObject blue;

        for(int i = 0; i < amount; i++){
            red = Instantiate(rBalloon);
            red.SetActive(false);
            RedPooler.Add(red);

            blue = Instantiate(bBalloon);
            blue.SetActive(false);
            BluePooler.Add(blue);
        }
    }

    public GameObject CreateRedBalloon(){
        GameObject red = Instantiate(rBalloon);
        red.SetActive(false);
        
        return red;
    }

    public GameObject CreateBlueBalloon(){
        GameObject blue = Instantiate(bBalloon);
        blue.SetActive(false);
        
        return blue;
    }

    public GameObject GetRedObject(){
        GameObject red;

        if(RedPooler.Count < 1){
            red = CreateRedBalloon();
        }
        else{
            red = RedPooler[0];
            RedPooler.Remove(red);
        }
        
        return red;
    }

    public GameObject GetBlueObject(){
        GameObject blue;

        if(BluePooler.Count < 1){
            blue = CreateBlueBalloon();
        }
        else{
            blue = BluePooler[0];
            BluePooler.Remove(blue);
        }
        
        return blue;
    }

    public void AddToPoolRed(GameObject red){
        RedPooler.Add(red);
    }

    public void AddToPoolBlue(GameObject blue){
        BluePooler.Add(blue);
    }
}
        
