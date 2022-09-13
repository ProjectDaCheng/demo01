using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class delete : MonoBehaviour
{
    public GameObject obj;

    public void del_Obj()
    {
        obj.SetActive(false);
    }
}
