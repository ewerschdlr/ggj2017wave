﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Inicial : MonoBehaviour {

    [SerializeField]
    float Tempo;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Tempo <= 0)
        {
            SceneManager.LoadScene("Fase 1");
        }
        Tempo -= Time.deltaTime;	
	}

    public void Pular()
    {
        SceneManager.LoadScene("Fase 1");
    }
}
