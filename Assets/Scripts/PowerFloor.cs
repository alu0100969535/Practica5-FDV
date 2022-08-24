using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using alu0100969535.Utils;

public class PowerFloor : MonoBehaviour {

    [SerializeField] private Collider2D playerCollider;

    [SerializeField] private Vector2 force;

    void OnTriggerEnter2D(Collider2D collider){
        if(collider.transform != playerCollider.transform) {
            return;
        }

        var rigidbody = Utils.Get<Rigidbody2D>(playerCollider.gameObject, "PlayerMovement needs a Rigidbody2D");
        rigidbody.AddForce(force, ForceMode2D.Impulse);
    }
}
