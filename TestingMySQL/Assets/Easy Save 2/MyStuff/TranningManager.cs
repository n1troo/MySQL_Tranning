using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class TranningManager : MonoBehaviour
{
    public GameObject tranningPrefab;

    private RectTransform panelMiddle;
    private List<GameObject> _traningPrefabs = new List<GameObject>();

	void Start ()
    {

        panelMiddle = GetComponentsInChildren<RectTransform>().Where(s=>s.name == "PanelMiddle").FirstOrDefault();
        for (int i = 0; i < 4; i++)
        {
            GameObject pref = (GameObject)Instantiate(tranningPrefab, transform.position, transform.rotation) as GameObject;
            pref.transform.SetParent(panelMiddle.transform);
            _traningPrefabs.Add(pref);
        }
    }
       
}
