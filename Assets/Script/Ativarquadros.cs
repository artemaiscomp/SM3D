using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ativarquadros : MonoBehaviour
{   

    private GameObject obj_NE;
    private GameObject obj_Grito;
    private GameObject obj_Mondrian;
    private GameObject obj_Guernica;
    private GameObject obj_Romero;
    private GameObject obj_Onda;
    private GameObject obj_Sacilotto;

    private GameObject[] quadros;
    // Start is called before the first frame update
    void Start()
    {
        quadros = GameObject.FindGameObjectsWithTag("Quadros");
        obj_NE = GameObject.Find("NE");
        obj_Grito = GameObject.Find("Grito");
        obj_Mondrian = GameObject.Find("Mondrian");
        obj_Guernica = GameObject.Find("Guernica");
        obj_Romero = GameObject.Find("Romero");
        obj_Onda = GameObject.Find("Onda");
        obj_Sacilotto = GameObject.Find("Sacilotto");

         for(int i = 0; i < quadros.Length; i++)
        {
            quadros[i].SetActive(false);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {   

         switch (other.name)
        {
            case "Porta_NE":
                for(int i = 0; i < quadros.Length; i++){
                quadros[i].SetActive(false);
                }
                quadros[0].SetActive(true);
                
                break;
            
            case "Porta_Grito":
            for(int i = 0; i < quadros.Length; i++){
                quadros[i].SetActive(false);
                }
                quadros[1].SetActive(true);
               
                break;
            
            case "Porta_Mondrian":
                for(int i = 0; i < quadros.Length; i++){
                quadros[i].SetActive(false);
                }
                quadros[2].SetActive(true);
                
                break;
            
            case "Porta_Guernica":
                for(int i = 0; i < quadros.Length; i++){
                quadros[i].SetActive(false);
                }
                quadros[3].SetActive(true);
                
                break;
            
            case "Porta_Romero":
                for(int i = 0; i < quadros.Length; i++){
                quadros[i].SetActive(false);
                }
                quadros[4].SetActive(true);
                break;
            
            case "Porta_Onda":
                for(int i = 0; i < quadros.Length; i++){
                quadros[i].SetActive(false);
                }
                quadros[5].SetActive(true);
                
                break;
            
            case "Porta_Normal":
                for(int i = 0; i < quadros.Length; i++){
                quadros[i].SetActive(false);
                }
                break;
            
            case "Porta_Sacilotto":
            for(int i = 0; i < quadros.Length; i++){
                quadros[i].SetActive(false);
                }
                quadros[6].SetActive(true);
                
                break;
        }
        

    }
}
