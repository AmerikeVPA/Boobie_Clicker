using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; 

public class Score : MonoBehaviour
{
    public int money;
    protected float time = 0;
    protected int oneSecond = 1, num = 1;
    public TextMeshProUGUI moneyTxt;

    public AudioSource audioS;
    public AudioClip clipCoin;

    private void Update()
	{
        time += Time.deltaTime;
        PlusQuantity();
        Touch();

    }

	//Esta función aumenta el valor * segundo del dinero. 
	public void PlusQuantity()
    {
        if (time >= oneSecond)
        {
            money++;
            moneyTxt.text = money.ToString();
            time = 0f;
        }
    }

    //Cada vez que el jugador presione sobre las boobs estas aumentarán el valor del dinero, y si su num aumenta (cuando el evento se activa)
    //entonces será aun más el dinero. 
    public void Touch()
    {
        if (Input.GetMouseButtonDown(0))
        {
            // Casts the ray and get the first game object hit
            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
            if (hit.collider.gameObject.CompareTag("Boobs") && num == 1)
            {
                money++;
                audioS.PlayOneShot(clipCoin);
            }
            if (hit.collider.gameObject.CompareTag("Boobs") && num == 2)
            {
                money += 2;
                audioS.PlayOneShot(clipCoin);
            }
        }
    }

}
