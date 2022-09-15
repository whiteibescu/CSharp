using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using UnityEditor.PackageManager.Requests;

public class JsonReader : MonoBehaviour
{
    private string url = "www.gist.com";

    void Start()
    {
        StartCoroutine(RequestJson());

    }

    IEnumerator RequestJson()
    {
        UnityWebRequest www = new UnityWebRequest(url);
        yield return www.SendWebRequest();

        if (www.error != null)
        {
            www.error.Log();
        }
        else
        {
            JObject jObjects = JObject.Parse(www.downloadHandler.text);
            string first = jObjects["Top"].ToString();

        }
    }
}
