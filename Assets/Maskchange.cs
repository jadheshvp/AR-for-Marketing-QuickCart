using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Maskchange : MonoBehaviour
{
    // Start is called before the first frame update

    public Material band1;
    public Material band2;
    /*public Material band3;
    public Material band4;*/
    Renderer rend;


    void Start()
    {
        rend = GetComponent<Renderer>();
        rend.enabled = true;
       
    }

    public void w1ColorSelect()
    {
        string buttonname = EventSystem.current.currentSelectedGameObject.name;

        if (buttonname == "SBU")
        {
            //change color to black

            rend.sharedMaterial = band1;
        }

        else if (buttonname == "SBL")
        {
            //change color to blue

            rend.sharedMaterial = band2;
        }


        public void w3Colorselect()
        { 
            string 

        }
    }

    /*public void w2ColorSelect()
    {
            string buttonname = EventSystem.current.currentSelectedGameObject.name;
        if (buttonname == "CMF")
        {
            //change color to blue 

            rend.sharedMaterial = band3;

        }

        else if (buttonname == "CML")
        {
            //change color to black

            rend.sharedMaterial = band4;
        }
        
    
    }*/
    

   /*public void w3ColorSelect()
    {
        string buttonname = EventSystem.current.currentSelectedGameObject.name;
    if (buttonname == "Gold Button")
    {
        //change color to gold 

        Color myColor = new Color();
        ColorUtility.TryParseHtmlString("#FFB000", out myColor);
        band3.color = myColor;

    }

    else if (buttonname == "Silver  Button ")
    {
        //change color to silver

        Color myColor = new Color();
        ColorUtility.TryParseHtmlString("#E7E7E7", out myColor);
        band3.color = myColor;
    }
    

    }*/


}
