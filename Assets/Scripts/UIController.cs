using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    public static UIController instance;

    public GameObject[] GoToHide;
    public GameObject Fish;
    public GameObject SideImage;

    public Button Airplane, Tree;

    public GameObject[] airplaneimages;

    void Start()
    {
        Airplane.onClick.AddListener(() => AirplaneButton());
        Tree.onClick.AddListener(() => TreeButton());
    }
    void Awake()
    {
        instance = this;
    }
    public void HideObjects(){
        foreach(var go in GoToHide){
            go.SetActive(false);
        }

        Fish.SetActive(true);
        SideImage.SetActive(true);
    }

    public void AirplaneButton(){
        Airplane.gameObject.SetActive(false);
        Tree.gameObject.SetActive(false);

         foreach(var go in airplaneimages){
            go.SetActive(true);
        }
    }
    public void TreeButton(){
        Airplane.gameObject.SetActive(false);
        Tree.gameObject.SetActive(false);
    }
}
