using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Management;

public class XRDeviceInitializer : MonoBehaviour
{
    public bool OnXR;
    // Start is called before the first frame update
   IEnumerator StartXR()
    {
        yield return XRGeneralSettings.Instance.Manager.InitializeLoader();
        if (XRGeneralSettings.Instance.Manager.activeLoader == null)
        {
            Debug.LogError("Initializing XR Failed. Check Editor or Player log for details.");
        }
        else
        {
            Debug.Log("Starting XR...");
            XRGeneralSettings.Instance.Manager.StartSubsystems();
            yield return null;
        }
    }


    void StopXR()
    {
        if (XRGeneralSettings.Instance.Manager.isInitializationComplete)
        {
            XRGeneralSettings.Instance.Manager.StopSubsystems();
            Camera.main.ResetAspect();
            XRGeneralSettings.Instance.Manager.DeinitializeLoader();
        }
    }
    //void OnDestroy(){StopXR();}
    // Update is called once per frame

    public void InitXR()
    {
        DontDestroyOnLoad(gameObject);
        StartCoroutine(StartXR());
        OnXR = true;
    }
    public void ExitXR()
    {
        StopXR();
    }
    
    void Update()
    {
       

    }
}
