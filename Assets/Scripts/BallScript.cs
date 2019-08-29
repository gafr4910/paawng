using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour {
//  public float             xPos;
//  public float             yPos;
    public float               speed = 1f;
    private Rigidbody          rb;

    // Start is called before the first frame update
    void Start() {
        rb = GetComponent<Rigidbody>();
        // Force
        rb.AddForce(transform.right * speed);
        rb.AddForce(transform.up * speed);
    }

    // Update is called once per frame
    void Update() {
          // Transform Manipulation
//        xPos += speed * Time.deltaTime;
//        yPos += speed * Time.deltaTime;
//        transform.position = new Vector3(xPos, yPos, 1);

          
            
    }

    private void OnTriggerEnter(Collider other) {

        if (other.tag == "Bounds") {
            Debug.Log("I'm out of bounds!");
            // Reset Ball
            // Increase Score
        }
    }

    public void Reset() {
        // Put Ball in the middle
        // Do other things?
    }
}
