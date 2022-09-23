using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using Newtonsoft.Json;
public class ParseJson : MonoBehaviour
{
    private string url = "https://jsonplaceholder.typicode.com/comments";
    private ScrollView scrollView;
    void Awake()
    {
        scrollView = GetComponent<ScrollView>();
    }

    public IEnumerator makeAddressRequest()
    {
        UnityWebRequest request = UnityWebRequest.Get(url);
        yield return request.SendWebRequest();


        if (request.result == UnityWebRequest.Result.ConnectionError || request.result == UnityWebRequest.Result.ProtocolError)
        {
            Debug.Log(request.error);
        }
        /*Success = 1,
         ConnectionError = 2,
         ProtocolError = 3,
         DataProcessingError = 4*/
        else
        {
            var address = JsonConvert.DeserializeObject<List<Address>>(request.downloadHandler.text);
            ScrollView.addressList = address;
        }
    }
}

public class Address
{
    public int postid { get; set; }
    public int id { get; set; }
    public string name { get; set; }
    public string email { get; set; }
    public string body { get; set; }
}
