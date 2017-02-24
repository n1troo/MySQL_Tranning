using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuManager : MonoBehaviour {

    public static TranningProgress Tranningdata = new TranningProgress();
    public GameObject MENU;
    public GameObject TRANNING;
    private void Awake()
    {
        MENU.SetActive(true);
        TRANNING.SetActive(false);
    }

    private void Start()
    { 
        //Pobieranie danych z bazy danych
        GetTranningValues();
    }

    public void GoToTraining()
    {
        MENU.SetActive(false);
        TRANNING.SetActive(true);
    }

    private void GetTranningValues()
    {
        print(DateTime.Now);
        WebController wGet = new WebController();
        StartCoroutine(wGet.DownloadTranning("PLAYER1"));    
    }

    void FixedUpdate()
    {
        if (Tranningdata != null)
        {
            print(DateTime.Now);
            print(Tranningdata.Day);
        }
    
    }
}
