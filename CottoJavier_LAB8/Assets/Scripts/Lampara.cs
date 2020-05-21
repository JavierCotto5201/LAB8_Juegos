using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lampara : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioClip hola;
    public AudioSource audioS;
    public Light light;
    void Start()
    {

        audioS = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {

        light.intensity = Mathf.Sin(Time.time *10) * 100;

    }

    private void OnTriggerEnter()
    {
        light.enabled = true;
        audioS.PlayOneShot(hola);
    }

    private void OnTriggerExit()
    {
        light.enabled = false;
        audioS.PlayOneShot(hola);
    }
}
