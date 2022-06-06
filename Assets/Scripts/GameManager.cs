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
    int moneyS, randNum = 0;
    protected float timeEvent; 
    protected int num = 1;
    public GameObject boobs, panel;
    public bool randomNumber = true; 
    public AudioSource audioS;
    public AudioClip clipCoin;

    public GameObject boobsO, bootyO, dickO; 

    public Score score; 

    public bool display = false; 

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
    }

    //Esta función activa el tip y la animación, para después en la animación mandar llamar a la función de abajo.
    public void Tip()
    {
        anim.SetBool("scroll", true);
        if(randomNumber == true)
		{
            int num = Random.Range(0, 17);
            tips.text = txt[num];
            randomNumber = false; 
        }         
    }
    //Esto desactiva la animación.
    public void TipOff()
	{
        anim.SetBool("scroll", false);
        randomNumber = true; 
	}

    //Esto te quita dinero de tu cartera y luego despliega la imagen de un hombre o mujer. 
    public void ImageUnlock()
	{
        if(score.money >= 100 && display == false)
		{
            anim.SetBool("naked", true); 
            score.money -= 1000;
            display = true;
		}
		else { anim.SetBool("naked", true); }
	}
    public void ImageOff() { anim.SetBool("naked", false); }
    public void Boobs()
	{
        if(boobsO.activeInHierarchy == true) { Debug.Log("true"); }
        else {

            dickO.SetActive(false);
            bootyO.SetActive(false);
            boobsO.SetActive(true);
        }        
	}
    public void Booty()
	{
        if (boobsO.activeInHierarchy == true) { Debug.Log("true"); }
		else {
            dickO.SetActive(false);
            boobsO.SetActive(true);
            bootyO.SetActive(false);
        }
    }

    public void Dick()
	{
        if (boobsO.activeSelf == false)
        {
            bootyO.SetActive(false);
            boobsO.SetActive(false);
            dickO.SetActive(true);
        }
    }

    /*
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
    */
}

   

    

