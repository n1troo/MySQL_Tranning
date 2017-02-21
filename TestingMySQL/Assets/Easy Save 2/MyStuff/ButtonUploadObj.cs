using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonUploadObj : ButtonHelper
{
    public override void onClicked()
    {
        print("onClicked" + gameObject.name);
        menuManager.GoToTraining();
        RemoveListener();
    }
}