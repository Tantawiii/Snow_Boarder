using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class CrashDetector : MonoBehaviour
{
    [SerializeField] float delayScene = .5f;
    [SerializeField] ParticleSystem crashEffect;
    [SerializeField] AudioClip crashSFX;
    bool doubleTouch = true;
    void OnTriggerEnter2D(Collider2D other) {
        if(other.tag == "Level" && doubleTouch){
            doubleTouch = false;
            FindObjectOfType<PlayerController>().DisableControls();
            crashEffect.Play();
            GetComponent<AudioSource>().PlayOneShot(crashSFX);
            Invoke("RestartScene", delayScene);
        }
    }
    void RestartScene(){
        SceneManager.LoadScene(0);
        Debug.Log("My head hurts!");
    }
}
