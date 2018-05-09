using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuCanvasHandler : MonoBehaviour
{

	public float _timeToChangeScene;
	private Text _play;
	void Start ()
	{
		_play = GameObject.Find("Play").GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
		if (_play.canvasRenderer.GetAlpha() == 0)
		{
			SceneManager.LoadScene(1);
		}
	}

	public void OnClickPlay()
	{
			WaitAndChange(_timeToChangeScene);
	}

	private void WaitAndChange(float time)
	{
		_play.CrossFadeAlpha(0,time,false);
		
	}
}
