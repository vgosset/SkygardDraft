using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class monitorChange : MonoBehaviour
{
    public Camera mainCam;
    private void OnMouseOver()
    {
        Debug.Log(mainCam.targetDisplay);
        if (Input.GetMouseButtonUp(0))
        {
            if (mainCam.targetDisplay == 0)
            {
                managerScript.instance.activeMonitor = 1;
                mainCam.targetDisplay = 1;
            }else if (mainCam.targetDisplay == 1)
            {
                managerScript.instance.activeMonitor = 0;
                mainCam.targetDisplay = 0;
            }
        }
    }
}
