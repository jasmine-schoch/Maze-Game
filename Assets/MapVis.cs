using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapVis : MonoBehaviour
{
    CanvasGroup canvasGroup;
    bool value = false;

    void Start()
    {
        canvasGroup = GetComponent<CanvasGroup>();
        
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("m")){
            value = !value;}
        {
            canvasGroup.alpha = value ? 1 : 0;
            //canvasGroup.interactable = value;
            //canvasGroup.blocksRaycasts = value;
        }
    }
}
