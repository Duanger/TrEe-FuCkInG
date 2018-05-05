using System.Collections;
using System.Collections.Generic;
using Fungus;
using UnityEngine;

public class WeatherSoundManager : MonoBehaviour
{
	private AudioSource _windSource;
	private float _audioVolume;
	public Fungus.Flowchart Chapter1Flowchart;
	// Use this for initialization
	void Start ()
	{
		_windSource = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update ()
	{
		_audioVolume = Chapter1Flowchart.GetFloatVariable("AshVolume");
		_windSource.volume = _audioVolume;
		Debug.Log(_windSource.volume);

	}
	
}
