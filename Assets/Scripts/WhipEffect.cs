using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhipEffect : MonoBehaviour
{

    float thresh = 3f;
    bool trigger = false;
    private Vector3 accelInfo;

    // Start is called before the first frame update
    void Start()
    {
        SensorManager.Instance.OnAcceleration += Whatever;
        Debug.Log("test2");
    }


    void Whatever(Vector3 vector)
    {
        accelInfo = vector;
        if (accelInfo.magnitude > thresh)
        {
            if (!trigger)
            {
                trigger = true;
                //GetComponent<AudioSource>().PlayOneShot(clip);
                SoundManager.Instance.PlaySound();
                Debug.Log("test");
            }
        }
        else if (trigger)
        {
            trigger = false;
        }
    }
}