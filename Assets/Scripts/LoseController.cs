﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoseController : MonoBehaviour
{
    public Text scoreText;

    private void Start()
    {
        scoreText.text = "Score: " + LevelManager.score.ToString();
    }

    // Update is called once per frame
    void Update ()
    {
		if (Input.touchCount > 0 || Input.GetMouseButtonDown(0) ||
            Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene("Play");
        }
	}
}
