using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuCanvasHandler : MonoBehaviour
{

	public float _timeToChangeScene;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void OnClickPlay()
	{
			StartCoroutine(WaitAndChange(_timeToChangeScene));
	}

	IEnumerator WaitAndChange(float time)
	{
		yield return new WaitForSeconds(time);
		SceneManager.LoadScene(1);
	}
}
