using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class HMDInfoManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if(!XRSettings.isDeviceActive)
        {
            Debug.Log("Žádný headset pøipojen");
        }
        else if (!XRSettings.isDeviceActive && (XRSettings.loadedDeviceName == "Mock HMD" || XRSettings.loadedDeviceName == "MockHMDDisplay"))
        {
            Debug.Log("Mock HMD je používáno");
        }
        else
        {
            Debug.Log("Používaný headset je: " + XRSettings.loadedDeviceName);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
