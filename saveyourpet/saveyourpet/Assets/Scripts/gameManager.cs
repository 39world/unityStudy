using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameManager : MonoBehaviour
{   

    public GameObject badThing1;
    public GameObject badThing2;
    public GameObject gameOverTxt;

    public Text timeTxt;
    float alive = 0.0f;
    public static gameManager I;

    public Animator anim;
    public GameObject pet;

    void Awake() 
    {
         I = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("makeBadThing",0.0f,0.5f);
    }

    void makeBadThing()
    {
        int category = Random.Range(1,3);
        if(category == 1){
            Instantiate(badThing1); 
        } else{
            Instantiate(badThing2);
        }
       
    }

    // Update is called once per frame
    void Update()
    {   
        alive += Time.deltaTime;
        timeTxt.text = alive.ToString("N2");
        
    }

    public void gameOver()
    {
        anim.SetBool("isDie",true);
        gameOverTxt.SetActive(true);
        Invoke("dead",1.2f);
    }

    void dead()
    {
        Time.timeScale = 0.0f;
        Destroy(pet);
    }
}
