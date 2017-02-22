using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class TranningManager : MonoBehaviour
{
    private RectTransform[] panels;
    public GameObject tranningPrefab; 

	void Start ()
    {
        panels = GetComponentsInChildren<RectTransform>();

        foreach (var ss in panels)
        {
            if (ss.name == "PanelMiddle")
            {

                for (int i = 0; i < 4; i++)
                {
                    GameObject pref = (GameObject)Instantiate(tranningPrefab, transform.position, transform.rotation) as GameObject;
                    pref.transform.SetParent(ss.transform); 
                }
            }
        }
	}
}
