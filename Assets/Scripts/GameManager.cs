using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 
using TMPro; 

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI moneyTxt, tips; 
    public string[] txt; 
    public GameObject[] positionT; 
    int money, randNum = 0;
    protected float time, timeEvent; 
    protected int oneSecond = 1;
    protected int num = 1;
    public GameObject boobs; 
    public AudioSource audioS;
    public AudioClip clipCoin;   

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime; 
        timeEvent += Time.deltaTime;  
        if(timeEvent > 25)
        {
            //StartCoroutine(RandomEvent());
            Tip(); 
            time = 0; 
        }
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
   	        if(hit.collider.gameObject.CompareTag("Boobs") && num == 1)
            {
                money++;
                audioS.PlayOneShot(clipCoin);
            }
            if(hit.collider.gameObject.CompareTag("Boobs") && num == 2)
            {
                money += 2;
                audioS.PlayOneShot(clipCoin);
            }
        }
    }

    public void Event1()
    {
        if(money >= 300)
        {

        }
    }

    public void Event2()
    {
        if(money >= 600)
        {
            
        }
    }

    public void Tip()
    {
        int num = Random.Range(0, 18); 
        tips.text = txt[num]; 
    }

     public IEnumerator RandomEvent()
    {
        int i = 0; 
        do
        {
            Debug.Log("Entro"); 
            randNum = Random.Range(0, 9);  
            boobs.transform.position = positionT[randNum].transform.position;
            yield return new WaitForSeconds(7);
            i++;   
        }while(i > 6);
        
    }
}

   

    

