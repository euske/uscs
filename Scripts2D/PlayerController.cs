// -*- tab-width: 4 -*-
using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

    // positive if the player is landed (able to jump).
    private int _landed = 0;

    void Update() {

    }

    void OnCollisionEnter2D(Collision2D coll) {
        if (coll.gameObject.tag == "floor") {
            _landed++;
        }
    }

    void OnCollisionExit2D(Collision2D coll) {
        if (coll.gameObject.tag == "floor" ||
            _landed--;
        }
    }
}
