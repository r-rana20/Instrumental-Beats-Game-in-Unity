using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Beats : MonoBehaviour
{
    // Start is called before the first frame update
	GameObject instrument;
	AudioSource drum, flute, piano, violin, xylophone;
    void Start()
    {
        instrument = GameObject.Find("Drum");
		drum = instrument.GetComponent<AudioSource>();
		instrument = GameObject.Find("Flute");
		flute = instrument.GetComponent<AudioSource>();
		instrument = GameObject.Find("Piano");
		piano = instrument.GetComponent<AudioSource>();
		instrument = GameObject.Find("Violin");
		violin = instrument.GetComponent<AudioSource>();
		instrument = GameObject.Find("Xylophone");
		xylophone = instrument.GetComponent<AudioSource>();
    }
	
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
			drum.Play();
		}
		else if (Input.GetKeyDown(KeyCode.F))
        {
            flute.Play();
        }
		else if (Input.GetKeyDown(KeyCode.P))
        {
            piano.Play();
        }
		else if (Input.GetKeyDown(KeyCode.V))
        {
            violin.Play();
        }
		else if (Input.GetKeyDown(KeyCode.X))
        {
            xylophone.Play();
        }
    }
}
