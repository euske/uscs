using UnityEngine;
using System.Collections;

public class AutoShadow : MonoBehaviour {
    
    void Awake()
    {
	foreach (GameObject obj in GameObject.FindGameObjectsWithTag("shadow")) {
	    obj.transform.rotation = transform.rotation;
	}
    }

}
