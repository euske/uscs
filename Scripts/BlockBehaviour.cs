// -*- tab-width: 4 -*-
using UnityEngine;
using System.Collections;

public class BlockBehaviour : MonoBehaviour {
	
    public float rate = 1f;
    public float size = 1f;
	
    private float t = 0f;

    void Update () {
        t += Time.deltaTime*rate;
        float x = transform.localPosition.x;
        float z = transform.localPosition.z;
        float y = Mathf.Sin (t);
        transform.localPosition = new Vector3(x, y*y*size, z);
    }
}
