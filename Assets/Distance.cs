using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Distance : MonoBehaviour
{
    public GameObject sphere1;
    public GameObject sphere2;
    public GameObject unitychan;

    void Start()
    {
        //unitychan.SetActive(false);

    }


    void Update()
    {
        float distance = Vector3.Distance(sphere1.transform.position, sphere2.transform.position);
        unitychan.SetActive(false);

        if (distance > 1.5f)
        {

            unitychan.SetActive(false);

        }
        else if (distance <= 1.5f)
        {
            unitychan.SetActive(true);

        }

        Debug.Log(distance);
    }
}