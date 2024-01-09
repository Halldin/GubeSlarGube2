using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enableDisable : MonoBehaviour
{
    [SerializeField] GameObject capcha;
    public void Pressed()
    {
        capcha.SetActive(!capcha.active);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
