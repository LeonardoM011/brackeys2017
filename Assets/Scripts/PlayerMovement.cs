using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public Rigidbody myRigidbody;
    public float forwardForce = 200.0f;
    public float strafeSpeed = 200.0f;

    float startTimer = 2.0f;

    void FixedUpdate() {

        myRigidbody.AddForce(new Vector3(0.0f, 0.0f, forwardForce * Time.deltaTime));

        if (Input.GetKey("d")) {
            myRigidbody.AddForce(new Vector3(strafeSpeed * Time.deltaTime, 0.0f, 0.0f), ForceMode.VelocityChange);
        }

        if (Input.GetKey("a")) {
            myRigidbody.AddForce(new Vector3(-strafeSpeed * Time.deltaTime, 0.0f, 0.0f), ForceMode.VelocityChange);
        }



        if(myRigidbody.position.y < -1.0f) {
            FindObjectOfType<GameManagerMain>().GameOver();
        }

        if(startTimer > 0) startTimer -= Time.deltaTime;

        if(myRigidbody.velocity == Vector3.zero && startTimer <= 0) {
            FindObjectOfType<GameManagerMain>().GameOver();
        }
    }
}
