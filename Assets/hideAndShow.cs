using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hideAndShow : MonoBehaviour
{
    public GameObject sphere;

    public void active_cube()
    {
        if (!sphere.activeInHierarchy)
        { sphere.SetActive(true); }
        else
        { sphere.SetActive(false); }
        //sphere.SetActive(true);
    }
}