using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Highlightable : MonoBehaviour
{

	public Sprite HighLightSprite;

	private Button _butt;

	private Color _whiteness;
	// Use this for initialization
	void Start ()
	{
		_butt = GetComponent<Button>();
_whiteness = Color.white;
		_whiteness.a = 0;

	}
	
	// Update is called once per frame
	void Update () {
		_butt.image.color = _whiteness;
	}

	public void death()
	{
		_whiteness.a = 12;
	
	}
}
