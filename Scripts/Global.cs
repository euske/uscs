using UnityEngine;
using System.Collections;

public class Global : MonoBehaviour {

    public static Global Instance;

    void Awake()
    {
        Instance = this;
    }
    
    void Update () {
        
    }
}
