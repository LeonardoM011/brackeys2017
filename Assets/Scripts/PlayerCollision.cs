using UnityEngine;

public class PlayerCollision : MonoBehaviour {

    public PlayerMovement movementScript;

    private void OnCollisionEnter(Collision collision) {
        if(collision.collider.tag == "Obstacle") {
            movementScript.enabled = false;
			FindObjectOfType<GameManagerMain>().GameOver();
        }
    }

}
