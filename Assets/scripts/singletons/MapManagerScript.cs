using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MapManagerScript : MonoBehaviour
{
    public bool selection;
    public ArrayList selceted = new ArrayList();

    private void Update()
    {
        if (selceted.Count > 2) {
            int temp = 0;
            foreach (int x in selceted)
            {
                temp += x;
            }

            managerScript.instance.selectedMap = temp;

            SceneManager.LoadScene(1);
        }
    }
}
