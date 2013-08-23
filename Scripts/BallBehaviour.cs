using UnityEngine;
using System.Collections;

public class BallBehaviour : MonoBehaviour {

    public float gravity = 1.0f;
    public float impact = 4.0f;
    public float variance = 0.5f;
    public AudioClip hitsound;
    
    void Update () {
	rigidbody.AddForce(Vector3.down * gravity);
    }

    void OnCollisionEnter(Collision col) {
	if (hitsound) {
	    audio.PlayOneShot(hitsound);
	}
	if (col.gameObject.tag == "player") {
            Vector3 force = (Vector3.up * impact +
                             Vector3.right * Random.Range(-variance, +variance) +
                             Vector3.forward * Random.Range(-variance, +variance));
	    rigidbody.AddForce(force, ForceMode.Impulse);
	}
    }
}
