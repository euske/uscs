// -*- tab-width: 4 -*-
using UnityEngine;
using System.Collections;

public class PlayerMove : MonoBehaviour
{
    public float speed = 1.0f;
    public float jumpacc = 4.0f;
    public float squatacc = 4.0f;

    public Transform target;
    public Transform shape;
    public AudioClip jumpsound;

    private bool landed = true;
    private float squat = 0f;
    private Vector2 goal = Vector2.zero;
    private Vector2 getxz(Transform transform)
    {
        return new Vector2(transform.position.x, transform.position.z);
    }

    void Update()
    {
        float r = speed * Time.deltaTime;
        float vx = Input.GetAxis("Horizontal") * r;
        float vz = Input.GetAxis("Vertical") * r;
        Move(vx, vz);
        Jump(Input.GetAxis("Jump") != 0);
    }
    
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "floor") {
            landed = true;
        }
    }
    
    private void Move(float vx, float vz)
    {
        Vector3 v = (Vector3.right * vx + Vector3.forward * vz);
        transform.Translate(v);
    }
    
    private void Jump(bool jumping)
    {
        if (jumping) {
            if (landed) {
                squat += Time.deltaTime*squatacc;
                squat = Mathf.Clamp(squat, 0.0f, 1.0f);
                if (shape) {
                    shape.transform.localPosition = new Vector3(0.0f, -squat*0.5f, 0.0f);
                    shape.transform.localScale = new Vector3(1.0f, 1.0f-squat*0.5f, 1.0f);
                }
            }
        } else if (squat != 0f) {
            if (shape) {
                shape.transform.localPosition = Vector3.zero;
                shape.transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
            }
            rigidbody.AddForce(Vector3.up * squat * jumpacc, ForceMode.Impulse);
            if (jumpsound) {
                audio.PlayOneShot(jumpsound);
            }
            landed = false;
            squat = 0f;
        }
    }

}
