using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GPSlocation : MonoBehaviour
{

    public float longitude;
    public float latitude;
    public Text gpsText;

    // Start is called before the first frame update
    IEnumerator Start()
    {
        if (Input.location.isEnabledByUser)
            StartCoroutine(GetLocation());
        if (!Input.location.isEnabledByUser)
            yield break;

    }
    private IEnumerator GetLocation()
    {
        Input.location.Start();
        while(Input.location.status == LocationServiceStatus.Initializing)
        {
            yield return new WaitForSeconds(1);
        }
        longitude = Input.location.lastData.longitude;
        latitude = Input.location.lastData.latitude;
        yield break;
    }

    // Update is called once per frame
    void Update()
    {
        longitude = Input.location.lastData.longitude;
        latitude = Input.location.lastData.latitude;
        gpsText.text = "Lat: " + latitude + "\n Lon: " + longitude;
    }
}
