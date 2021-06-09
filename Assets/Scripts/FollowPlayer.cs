using UnityEngine;

public class FollowPlayer : MonoBehaviour {

    public Transform playerTransf;
    public Vector3 offset;

	void Update () {
        transform.position = playerTransf.position + offset;
	}
}
