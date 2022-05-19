using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menu : MonoBehaviour
{
    public GameObject title, playT, opT, quitT; 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void PlayTouch()
    {
        title.SetActive(false); 
        playT.SetActive(false); 
        opT.SetActive(false);
        quitT.SetActive(false);  
    }

    public void Options()
    {

    }

    public void Quit()
    {
        Application.Quit(); 
    }
}
