using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestPhysics : MonoBehaviour
{
    // Start is called before the first frame update
    void Start() {
        Debug.Log("Initialized");
    }

    void OnCollisionEnter2D(Collision2D collision){
        Debug.Log("OnCollisionEnter2D");
    }

    void OnCollisionStay2D(Collision2D collision) {
        Debug.Log("OnCollisionStay2D");
    }

    void OnCollisionExit2D(Collision2D collision) {
        Debug.Log("OnCollisionExit2D");
    }

    void OnTriggerEnter2D(Collider2D collider){
        Debug.Log("OnTriggerEnter2D");
    }

    void OnTriggerStay2D(Collider2D collider) {
        Debug.Log("OnTriggerStay2D");
    }

    void OnTriggerExit2D(Collider2D collider) {
        Debug.Log("OnTriggerExit2D");
    }

}
