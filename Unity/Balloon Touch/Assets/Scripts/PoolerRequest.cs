using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class PoolerRequest : MonoBehaviour
{
    public string Request = "Cube_Rojo";

    public bool run =  false;

    void Update(){
        if(run == true){
            RunRequest();
            run = false;
        }
    }

    public void RunRequest(){
        string[] types = Request.Split('_');
        string type = types[0];
        
        List <string> subtype = types.ToList <string>();
        subtype.Remove(type);
        
        GameObject obj = Pooler.SINGLETON.GetObjectInPool(type, subtype.ToArray());

        if(obj != null){
            obj.SetActive(true);
        }
        else{
            Debug.Log("No existe.");
        }  
    }
}
        

        

