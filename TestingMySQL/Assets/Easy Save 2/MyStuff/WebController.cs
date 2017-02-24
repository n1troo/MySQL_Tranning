using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WebController : MonoBehaviour
{
    public enum Mode { Upload, Download };
    
    [Header("Konfiguracja")]
    public Mode mode = Mode.Download;
    public string url = "http://n1troo.usermd.net/ES2.php";
    public string filename = "ustawienia.txt";
    
    [Header("Zmienne test")]
    [Range(0, 10)]
    public int WartoscDay = 1;
    public string webUsername = "test";
    public string webPassword = "tset321";


   


    private IEnumerator UploadTranning(TranningProgress traning, string tag)
    {
        string myURL = url + "?webfilename=myFile.txt";
        ES2Web web = new ES2Web(myURL + "&tag=" + tag);
        web.settings.webPassword = webPassword;
        web.settings.webUsername = webUsername;

        // Start uploading our data and wait for it to finish.
        yield return StartCoroutine(web.Upload(traning));

        if (web.isError)
        {
            // Enter your own code to handle errors here.
            // For a list of error codes, see www.moodkie.com/easysave/ES2Web.ErrorCodes.php
            Debug.LogError(web.errorCode + ":" + web.error);
        }
    }

    public IEnumerator DownloadTranning(string tag)
    {
        string myURL = url + "?webfilename=myFile.txt";
        ES2Web web = new ES2Web(myURL);
        web.settings.webPassword = webPassword;
        web.settings.webUsername = webUsername;

        // Start downloading our data and wait for it to finish.
        yield return StartCoroutine(web.Download());

        if (web.isError)
        {
            // Enter your own code to handle errors here.
            Debug.LogError(web.errorCode + ":" + web.error);
            yield break;
        }
        // web.SaveToFile("myFile.txt");
       // MenuManager.Tranningdata = web.Load<TranningProgress>(tag);
    }
}
