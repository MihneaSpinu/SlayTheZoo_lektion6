using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomAtcSound : MonoBehaviour
{

    [SerializeField] private AudioClip[] sounds;
    [SerializeField] private AudioSource source;

    // Start is called before the first frame update
    void Start()
    {
        source = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            source.clip = sounds[Random.Range(0, sounds.Length)];
            source.Play();
            Debug.Log("ATC Sound Played"+ source.clip);
        }
       
    }
}
