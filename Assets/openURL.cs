using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class openURL : MonoBehaviour
{
    //GameObject obj;

    public void Launch(string url)
    {
        Application.OpenURL(url);
    }

}
