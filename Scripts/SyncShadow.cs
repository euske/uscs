// -*- tab-width: 4 -*-
using UnityEngine;
using System.Collections;

public class SyncShadow : MonoBehaviour {

    public Transform target;
	
    void Update () {
        transform.position = target.position;
    }
}
