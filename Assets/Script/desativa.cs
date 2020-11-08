using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class desativa : MonoBehaviour
{
    private GameObject logo;
    // Start is called before the first frame update
    void Start()
    {
        logo = GameObject.Find("Logo");
        logo.SetActive(false);
        
    }

    // Update is called once per frame
    void Update()
    {
        
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
}
