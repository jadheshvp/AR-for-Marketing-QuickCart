using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Watchselect : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject WatchMode1;
    public GameObject WatchMode2;
    public GameObject WatchMode3;

    public GameObject W1Window;
    public GameObject W2Window;
    public GameObject W3Window;

    Animation w1WindowAnimation;
    Animation w2WindowAnimation;
    Animation w3WindowAnimation;


    void Start()
    {
        w1WindowAnimation = W1Window.GetComponent<Animation>();
        w2WindowAnimation = W2Window.GetComponent<Animation>();
        w3WindowAnimation = W3Window.GetComponent<Animation>();


    }
    public void WatchOneButtonClicked()
    {
        // Show watch model on user"s Wrist
        WatchMode1.SetActive(true);
        WatchMode2.SetActive(false);
        WatchMode3.SetActive(false);

        // Play watch window animatiom

        w1WindowAnimation["Watch1"].speed = 1;
        w1WindowAnimation.Play();

    }

    public void WatchtwoButtonClicked()
    {
        // Show watch model on user"s Wrist
        WatchMode1.SetActive(false);
        WatchMode2.SetActive(true);
        WatchMode3.SetActive(false);


        // Play watch window animatiom

        w2WindowAnimation["Watch2"].speed = 1;
        w2WindowAnimation.Play();

    }
    public void WatchthreeButtonClicked()
    {
        // Show watch model on user"s Wrist
        WatchMode1.SetActive(false);
        WatchMode2.SetActive(false);
        WatchMode3.SetActive(true);


        // Play watch window animatiom

        w3WindowAnimation["Watch3"].speed = 1;
        w3WindowAnimation.Play();

    }

    public void CloseButtonClicked()
    {
        string buttonname = EventSystem.current.currentSelectedGameObject.name;

        if (buttonname == "w1close")
        {
            //Play the w1 window close animation

            w1WindowAnimation["Watch1"].speed = -1;
            w1WindowAnimation["Watch1"].time = w1WindowAnimation["Watch1"].length;
            w1WindowAnimation.Play();

        }
        else if(buttonname == "w2close")
        {
            //Play the w2 window close animation

            w2WindowAnimation["Watch2"].speed = -1;
            w2WindowAnimation["Watch2"].time = w2WindowAnimation["Watch2"].length;
            w2WindowAnimation.Play();


        }
        else if(buttonname == "w3close")
        {
            //Play the w3 window close animation

            w3WindowAnimation["Watch3"].speed = -1;
            w3WindowAnimation["Watch3"].time = w3WindowAnimation["Watch3"].length;
            w3WindowAnimation.Play();

        }
    }
}

   
