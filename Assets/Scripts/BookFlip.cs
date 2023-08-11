using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BookFlip : MonoBehaviour
{
    public AutoFlip aflip;
    public void OnFlipComplete(){
        UIController.instance.HideObjects();
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.A)){
            aflip.FlipRightPage();
        }
    }
}
