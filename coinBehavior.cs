using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinBehavior : MonoBehaviour {
    public Text scoreText;
    public int score = 0;
    
    void OnCollisionEnter(Collision collision) {
        if(collision.gameObject.tag == "Coin") {
            score += 10;
            scoreText.text = "Score: " + score;
            Destroy(collision.gameObject);
        }
    }
}
