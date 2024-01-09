using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class checkbox : MonoBehaviour
{
    public bool correct;
    [SerializeField] Toggle toggle;
    bool state;
    void Start()
    {
        
    }

    public void Change()
    {
        state = toggle.isOn;
    }
}
