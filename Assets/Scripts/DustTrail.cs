using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DustTrail : MonoBehaviour
{
    [SerializeField] ParticleSystem slidingEffect;
    void OnCollisionEnter2D(Collision2D other) {
        if(other.gameObject.tag == "Level"){
            slidingEffect.Play();
        }
    }
    private void OnCollisionExit2D(Collision2D other) {
        if(other.gameObject.tag == "Level"){
            slidingEffect.Stop();
        }
    }
}
