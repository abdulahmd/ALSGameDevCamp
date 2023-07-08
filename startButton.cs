using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startButton : MonoBehaviour
{
    void Start() {

    }

    void Update() {

    }
    
    public void LoadScene() {
        SceneManager.LoadScene(1);
    }
}
