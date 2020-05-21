using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Linterna : MonoBehaviour
{
    // Start is called before the first frame update
    public Light light;
    public AudioClip OnOff;
    public AudioSource audioS;

    void Start()
    {

        light = GetComponent<Light>();

        audioS = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (light.intensity > 0)
            {
                light.intensity = 0;
                audioS.PlayOneShot(OnOff);
            }
            else
            {
                light.intensity = 8;
                audioS.PlayOneShot(OnOff);
            }
        }

        /*RaycastHit hitInfo;
            Ray myRay = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(myRay, out hitInfo, 20))
                Debug.Log(hitInfo.collider.gameObject.name);*/


    }
}
