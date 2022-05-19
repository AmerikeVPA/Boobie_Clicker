using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 
using TMPro; 

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI moneyTxt; 
    public GameObject[] positionT; 
    int money, randNum = 0;
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

        //Esta función aumenta el valor * segundo del dinero. 
        PlusQuantity(); 
        //Esta función es para que al tocar una vez aumente más rápido el dinero. 
        Touch(); 
          
    }

    public void PlusQuantity()
    {
        if(time >= oneSecond)
        {

            money++;
            moneyTxt.text = money.ToString() ;
            time = 0f;  
        }
    }

    public void Touch()
    {
        if(Input.GetMouseButtonDown(0))
        {
   	        // Casts the ray and get the first game object hit
   	        RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
   	        if(hit.collider.gameObject.CompareTag("Boobs"))
            {
                money++;
            }
        }
    }

/*
    public void Event_Teleport()
    {
        positionT[randNum] = Random.Range(0,7);
         
    }
    */
}
