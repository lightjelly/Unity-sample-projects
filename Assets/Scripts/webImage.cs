using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class webImage : MonoBehaviour {

    [SerializeField] 
    public string URL;

    IEnumerator Start()
    {
        WWW www = new WWW(URL); //Create new www object from URL
        yield return www;

        GetComponent<RawImage>().texture = www.texture; //Set texture of Ui object
        GetComponent<RawImage>().SetNativeSize(); //optional, Set image to original size
    }
	
}
