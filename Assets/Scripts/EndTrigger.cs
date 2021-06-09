using UnityEngine;

public class EndTrigger : MonoBehaviour {

    public GameManagerMain gameManager;

    void OnTriggerEnter(Collider other) {

        gameManager.CompleteLevel();

    }

}
