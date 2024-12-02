using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class mapClick : MonoBehaviour
{
    public GameObject P1cross, P2cross;
    public int ID;

    private MapManagerScript MM;
    private void Start()
    {
        MM = GameObject.Find("MapManager").GetComponent<MapManagerScript>();
    }
    private void OnMouseOver()
    {
        
        if (Input.GetMouseButtonUp(0))
        {
            if (!MM.selceted.Contains(ID))
            {
                Debug.Log("yay");
                switch (managerScript.instance.activePlayer)
                {
                    case 0:
                        MM.selceted.Add(ID);
                        Instantiate(P1cross, this.transform);
                        managerScript.instance.activePlayer = 1;
                        break;
                    case 1:
                        MM.selceted.Add(ID);
                        Instantiate(P2cross, this.transform);
                        managerScript.instance.activePlayer = 0;
                        break;
                }
                
            }
            
        }
    }
}
