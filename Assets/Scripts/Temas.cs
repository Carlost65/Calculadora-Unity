using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Temas : MonoBehaviour
{
    [SerializeField]private Camera MainCamera;
    [SerializeField]private Button[] Buttons;
    [SerializeField]private Text[] BTexts;
    [SerializeField] private Text TextI;
    [SerializeField] private Text TextII;
    private Color BgColor;
    private Color ButonColor;
    private string tema = "Claro";

    private void Start() 
    {
      Change_tema();
    }
    public void Change_tema()
    {
        if(tema == "Escuro")
        {
            tema = "Claro";
            MainCamera.backgroundColor = Color.white;
            TextI.color = Color.black;
            TextII.color = Color.black;
              foreach (var item in Buttons)
            {
              item.image.color = Color.blue;
            }
            foreach (var item in BTexts)
            {
              item.color = Color.black;
            }

        }
        else if(tema == "Claro")
        {
            tema = "Escuro";
            MainCamera.backgroundColor = Color.black;
            TextI.color = Color.white;
            TextII.color = Color.white;
            foreach (var item in Buttons)
            {
              item.image.color = Color.gray;
            }
            foreach (var item in BTexts)
            {
              item.color = Color.blue;
            }
        }
    }

    private void ButtonColor()
    {
        foreach (var item in Buttons)
        {
         item.image.color = Color.gray;
        }
    }
}
