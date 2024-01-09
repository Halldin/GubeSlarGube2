using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Capcha : MonoBehaviour
{
    [SerializeField] CapchaScriptableObject[] capchas;
    CapchaScriptableObject capcha;
    Image[,] images;

    void Start()
    {
        //capcha = capchas[Random.Range(0, capchas.Length - 1)];
        images = new Image[3,3];
        foreach(Toggle toggle in gameObject.GetComponentsInChildren<Toggle>(true)){
            int x = int.Parse(toggle.gameObject.name.Substring(0,1));
            int y = int.Parse(toggle.gameObject.name.Substring(2,1));
            
            images[x,y] = toggle.gameObject.GetComponent<Image>();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
