using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class verify : MonoBehaviour
{
    [SerializeField] SceneLoader loader;
    [SerializeField] Color correctColor;
    [SerializeField] Color falseColor;
    [SerializeField] float speed;
    [SerializeField] Image image;
    Color targetColor = Color.green;

    void FixedUpdate()
    {
        targetColor = Color.Lerp(targetColor, correctColor, speed);
        image.color = targetColor;
    }

    public void Verify()
    {
        bool verify = true;
        foreach(checkbox checkbox in FindObjectsOfType<checkbox>()){
            if(checkbox.correct != checkbox.gameObject.GetComponent<Toggle>().isOn){
                verify = false;
                print("s");
            }
        }

        if(verify){
            loader.LoadDynamicScene();
        }else{
            targetColor = falseColor;
        }
    }
}
