using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonHelper : MonoBehaviour
{
    MenuManager _menuManager;
    public MenuManager menuManager
    {
        get
        {
            if (_menuManager == null)
            {
                _menuManager = GetComponentInParent<MenuManager>();
            }
            return _menuManager;
        }
    }
    private void OnEnable()
    {
        GetComponent<Button>().onClick.AddListener(onClicked);
    }
    void OnDisable()
    {
        RemoveListener();
    }

    virtual public void onClicked() { }

    public void RemoveListener()
    {
        GetComponent<Button>().onClick.RemoveListener(onClicked);
    }
}
