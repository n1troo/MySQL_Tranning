using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuManager : MonoBehaviour {

    public GameObject MENU;
    public GameObject TRANNING;

    private void Awake()
    {
        MENU.SetActive(true);
        TRANNING.SetActive(false);
    }

    public void GoToTraining()
    {
        MENU.SetActive(false);
        TRANNING.SetActive(true);
    }

    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
