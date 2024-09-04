using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Level_Intro : MonoBehaviour
{

	public string introText = "LEVEL";
	public float duration = 2.0f;
	// Start is called before the first frame update
	void Start()
	{
		gameObject.GetComponent<Text>().text = introText;
		StartCoroutine("LevelIntro");
	}

	IEnumerator LevelIntro()
	{
		yield return new WaitForSeconds(2.0f);
		gameObject.SetActive(false);
	}
}
