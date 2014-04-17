// -*- tab-width: 4 -*-
using UnityEngine;
using System.Collections;

public class SceneCreation : MonoBehaviour {
	
    public Transform blockPrefab;
	
    public int floorWidth = 10;
    public float floorHeight = 1f;
    public float floorSpeed = 1f;
	
    void Awake() {
        for (int x = -floorWidth; x <= floorWidth; x++) {
            for (int z = -floorWidth; z <= floorWidth; z++) {
                float h = Random.Range(floorHeight/2, floorHeight);
                Transform block = Instantiate(blockPrefab, Vector3.zero, 
                                              transform.rotation) as Transform;
                block.parent = transform;
                block.transform.localPosition = new Vector3(x, -h, z);
                block.transform.localScale = new Vector3(1f, h*2, 1f);
                BlockBehaviour script = block.GetComponent<BlockBehaviour>();
                script.size = h;
                script.rate = Random.Range (floorSpeed/2, floorSpeed);
            }
        }
    }
}
