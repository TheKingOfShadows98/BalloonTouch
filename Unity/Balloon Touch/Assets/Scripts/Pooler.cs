using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Pooler : MonoBehaviour
{
    public static Pooler SINGLETON;
    public List <GameObject> PoolBalloon = new List <GameObject>();

    private void Awake(){
        SINGLETON = this;
    }

    public GameObject GetObjectInPool(string objectType, string[] subtypes){
        GameObject result = null;
        
        PoolBalloon.Find(x => {
            
            bool _result = x.name.Contains(objectType);
            
            foreach(string _subtype in subtypes){
               
               if(_subtype != "" || _subtype != null || _subtype != "")
               
               _result = _result && x.name.Contains(_subtype);
               Debug.Log(_result); 
            }
            
            return _result;
        });

        if(result != null){
            PoolBalloon.Remove(result);
        }

        
        
        return result;
    }

    public void AddToPool(GameObject _gameObject){
        PoolBalloon.Add(_gameObject);
    }
}
        
        
