using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioPlay : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public AudioSource SoundEff;
    private void OnCollisionEnter(Collision collision)
    {
        SoundEff.Play();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
