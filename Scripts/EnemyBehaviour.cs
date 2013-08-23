using UnityEngine;
using System.Collections;

public class EnemyBehaviour : MonoBehaviour {

    public float speed = 5f;
    public AudioClip hitsound;
    public AudioClip explosion;
    public GameManager manager;

    void Start () {
	Jump();
    }
	
    void OnCollisionEnter(Collision col) {
	if (col.gameObject.tag == "buller") {
	    audio.PlayOneShot(hitsound);
	} else if (col.gameObject.tag == "floor") {
	    Die();
	} else {
	    Jump();
	}
    }
    
    void Jump() {
	float vx = Random.Range(-1f, +1f);
	float vz = Random.Range(-1f, +1f);
	Vector3 v = new Vector3(vx, 1f, vz);
	rigidbody.AddForce(v*speed, ForceMode.Impulse);
    }

    void Die()
    {
	audio.PlayOneShot(explosion);
	manager.SendMessage("ScoreEnemy");
	renderer.enabled = false;
	Destroy(gameObject, 3);
    }
}
