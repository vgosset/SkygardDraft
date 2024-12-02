using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class managerScript : MonoBehaviour
{
    public static managerScript instance;

    public int selectedMap = 0;
    public int activePlayer = 0;
    public int activeMonitor = 1;

    private void Awake()
    {
        if (instance != null)
        {
            Destroy(gameObject);
            return;
        }

        instance = this;

        DontDestroyOnLoad(gameObject);
    }
}
