using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class characterClick : MonoBehaviour
{
    public GameObject P1cross, P2cross;
    public GameObject P1select, P2select;
    public int bans, picks;
    public int ID;

    private CharacterManager CM;
    private void Start()
    {
        CM = GameObject.Find("characterManager").GetComponent<CharacterManager>();
    }
    private void OnMouseOver()
    {
        if (Input.GetMouseButtonUp(0))
        {
            if ((!CM.selceted1.Contains(ID) || !CM.selceted2.Contains(ID)) && (CM.selceted1.Count + CM.selceted2.Count < (picks*2+bans*2)))
            {
                switch (managerScript.instance.activePlayer)
                {
                    case 0:
                        CM.selceted1.Add(ID);
                        if (CM.selceted1.Count > bans)
                        {
                            Instantiate(P1select, this.transform);
                        }
                        else
                        {
                            Instantiate(P1cross, this.transform);
                        }
                        
                        managerScript.instance.activePlayer = 1;
                        break;
                    case 1:
                        CM.selceted2.Add(ID);
                        if (CM.selceted2.Count > bans)
                        {
                            Instantiate(P2select, this.transform);
                        }
                        else
                        {
                            Instantiate(P2cross, this.transform);
                        }
                        managerScript.instance.activePlayer = 0;
                        break;
                }

            }

        }
    }
}
