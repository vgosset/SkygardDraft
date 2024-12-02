using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bgSelectedMapSetter : MonoBehaviour
{

    public Sprite map0, map1, map2, map3;
    // Start is called before the first frame update
    void Start()
    {
        switch (managerScript.instance.selectedMap)
        {
            case 6:
                this.GetComponent<SpriteRenderer>().sprite = map0;
                break;
            case 5:
                this.GetComponent<SpriteRenderer>().sprite = map1;
                break;
            case 4:
                this.GetComponent<SpriteRenderer>().sprite = map2;
                break;
            case 3:
                this.GetComponent<SpriteRenderer>().sprite = map3;
                break;
    } 
    }
}
