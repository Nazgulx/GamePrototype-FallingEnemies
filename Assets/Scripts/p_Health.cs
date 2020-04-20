using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class p_Health : MonoBehaviour
{
    public int health;
    public int numOfHeart;
    public Image[] hearts;
    public Sprite fullHeart;
    public Sprite emptyHeart;
    public GameObject EnemyManager;

        // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        for(int i=0; i < hearts.Length; i++){

            if(i<health){
                hearts[i].sprite = fullHeart;
            }else{
                hearts[i].sprite = emptyHeart;
            }

            if(i < numOfHeart){
                hearts[i].enabled = true;
            }else{
                hearts[i].enabled = false;
            }
        }

        if(health>numOfHeart){
            numOfHeart=health;
        }

        if(health == 0){
            GetComponent<P_Movement>().enabled = false;
            EnemyManager.GetComponent<EnemyManager>().enabled = false;
        }

    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            health -= 1;
        }
    }
}
