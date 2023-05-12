using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomDmgSound : MonoBehaviour
{

    [SerializeField] private AudioClip[] sounds;
    [SerializeField] private AudioSource source;

    // Start is called before the first frame update
    void Start()
    {
        source = GetComponent<AudioSource>();
    }

    public void Die()
    {
        Debug.Log("I died");
        Destroy(gameObject);
    }


    // Update is called once per frame
    private void OnTriggerEnter(Collider collider)
        {
            source.clip = sounds[Random.Range(0, sounds.Length)];
            source.Play();
            Debug.Log("ATC Sound Played" + source.clip);
        }


    }
