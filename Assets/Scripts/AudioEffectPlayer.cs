using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioEffectPlayer : MonoBehaviour
{
    public AudioSource effect;

    private void Start()
    {
        effect.volume = PlayerPrefs.GetFloat("EffectsVolume");
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            effect.Play();
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            effect.Play();
        }
    }
}
