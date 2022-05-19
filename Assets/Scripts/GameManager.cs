using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 
using TMPro; 

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI moneyTxt; 
    int money;
    protected float time; 
    protected int oneSecond = 1; 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime; 

        if(time >= oneSecond)
        {

            money++;
            moneyTxt.text = money.ToString() ;
            time = 0f;  
        }

        Touch(); 
          
    }

    public void Touch()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
   	        RaycastHit hit;
   	        // Casts the ray and get the first game object hit
   	        Physics.Raycast(ray, out hit);
   	        if(hit.collider.gameObject.CompareTag("Boobs"))
               {
                   money++; 
               }
        }
    }
}
