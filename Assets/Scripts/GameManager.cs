using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 
using TMPro; 

public class GameManager : MonoBehaviour
{
    public Animator anim; 
    public TextMeshProUGUI tips; 
    public string[] txt; 
    public GameObject[] positionT; 
    int money, randNum = 0;
    protected float timeEvent; 
    protected int num = 1;
    public GameObject boobs, panel;
    public bool randomNumber = true; 
    public AudioSource audioS;
    public AudioClip clipCoin;   

    // Update is called once per frame
    void Update()
    {

        timeEvent += Time.deltaTime;  
        if(timeEvent > 35)
        {
            //StartCoroutine(RandomEvent());
            Tip(); 
            timeEvent = 0;
            Debug.Log("0"); 
        }
        Touch();  
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

    //Esta función activa el tip y la animación, para después en la animación mandar llamar a la función de abajo.
    public void Tip()
    {
        anim.SetBool("scroll", true);
        if(randomNumber == true)
		{
            int num = Random.Range(0, 18);
            tips.text = txt[num];
            randomNumber = false; 
        }
         
    }

    //Esto desactiva la animación.
    public void TipOff()
	{
        anim.SetBool("scroll", false);
        randomNumber = false; 
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

   

    

