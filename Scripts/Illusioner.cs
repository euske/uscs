// -*- tab-width: 4 -*-
using UnityEngine;
using System.Collections;

public class Illusioner : MonoBehaviour {

    public float loop = 6f;
	
    void Update () {
        Vector3 p = transform.position;
        float y0 = Mathf.Floor(p.y / loop) * loop;
        transform.position = new Vector3(p.x, p.y-y0, p.z);
    }
}
