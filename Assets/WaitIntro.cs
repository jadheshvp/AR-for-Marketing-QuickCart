using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WaitIntro : MonoBehaviour
{
    // Start is called before the first frame update
    public float wait_time = 5f;

    void Start()
    {
        StartCoroutine(IntroWait());

    }
    IEnumerator IntroWait()
    {
        yield return new WaitForSeconds(wait_time);

        SceneManager.LoadScene(1);


    }

    
}
