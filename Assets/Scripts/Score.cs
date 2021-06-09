using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

    public Transform player;
    public Text score;
    private float start;
    private int numb;
    private int ostatak;

    void Start() {
        start = player.position.z;
    }

    void Update () {
        numb = ((int)(Mathf.Abs(Mathf.Floor(start - player.position.z))));

        // Svakih 5 broji
        if(numb % 10 < 5) {
            ostatak = 0;
        } else {
            ostatak = 5;
        }
        
        // Makni znamenku jedinica
        numb /= 10;
        numb *= 10;

        numb += ostatak;

        score.text = "Score: " + numb.ToString();
	}
}
