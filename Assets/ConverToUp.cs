using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ConverToUp : MonoBehaviour, IPointerEnterHandler
{
	public Sprite HighlightSprite;
	private Image _butt;
	void Start ()
	{
		_butt= GetComponent<Image>();
		_butt.CrossFadeAlpha(0,0,true);
	}
	
	// Update is called once per frame
	void OnMouseOver ()
	{

	}

	public void OnPointerEnter(PointerEventData pointEvent)
	{
		_butt.CrossFadeAlpha(255,0,true);
		_butt.sprite = HighlightSprite;
	}
}
