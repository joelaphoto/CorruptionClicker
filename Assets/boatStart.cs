﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class boatStart : MonoBehaviour
{

	public float delay = 3;

	// Use this for initialization
	void Start()
	{
		StartCoroutine(LoadSceneAfterTime(delay));
	}


	IEnumerator LoadSceneAfterTime(float delay)
	{
		yield return new WaitForSeconds(delay);
		SceneManager.LoadScene("ShootEmUp");
	}
	// Update is called once per frame
	void Update()
	{

	}
}
