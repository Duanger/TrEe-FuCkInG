using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ConverToUp : MonoBehaviour
{

	private Text _text;
	void Start ()
	{
		_text = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update ()
	{
	_text.text.ToUpper();
      
	}
}
