using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class desativa : MonoBehaviour
{
    private GameObject logo;
    private GameObject monolith;
    [SerializeField]
    private Button buttonBack;
    private GameObject tutorialObj;
    private bool tutorialOn = true;
    private float countdown = 5.0f;
    
    void Start()
    {
        logo = GameObject.Find("Logo");
        monolith = GameObject.Find("Monolito");
        tutorialObj = GameObject.Find("Tutorial");
        buttonBack.onClick.AddListener(ClickBack);

        logo.SetActive(false);

        if (MenuPlayGame.monolithIsTrue == true) monolith.SetActive(true);
        else {
            monolith.SetActive(false);
            logo.SetActive(false);
        }

    }
    void Update()
    {
       if(tutorialOn == true && Input.GetMouseButtonDown(0)){
               tutorialObj.SetActive(false);
       }
    }

    void OnTriggerEnter(Collider other)
        {
            if(other.name == "Porta_Normal"){
                logo.SetActive(true);
            }

            if(other.tag =="porta" && other.name !="Porta_Normal"){
                logo.SetActive(false);
            }
            
        }

     void ClickBack()
    {
        SceneManager.LoadScene("Menu");
    }
}
