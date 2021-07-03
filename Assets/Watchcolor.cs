using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Watchcolor : MonoBehaviour
{
    // Start is called before the first frame update

    public Material band1;
    public Material band2;
    public Material band3;

    void Start()
    {
        
    }

    public void w1ColorSelect()
    {
        string buttonname = EventSystem.current.currentSelectedGameObject.name;

        if (buttonname == "BUButton")
        {
            //change color to blue

            Color myColor = new Color();
            ColorUtility.TryParseHtmlString("#0006C8", out myColor);
            band1.color = myColor;
        }

        else if (buttonname == "BLButton")
        {
            //change color to black

            Color myColor = new Color();
            ColorUtility.TryParseHtmlString("#000000", out myColor);
            band1.color = myColor;
        }
    }

    public void w2ColorSelect()
    {
            string buttonname = EventSystem.current.currentSelectedGameObject.name;
        if (buttonname == "RButton")
        {
            //change color to blue 

            Color myColor = new Color();
            ColorUtility.TryParseHtmlString("#B70000", out myColor);
            band2.color = myColor;

        }

        else if (buttonname == "BButton")
        {
            //change color to black

            Color myColor = new Color();
            ColorUtility.TryParseHtmlString("#000000", out myColor);
            band2.color = myColor;
        }
        
    
    }
    

    public void w3ColorSelect()
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
    

    }


}
