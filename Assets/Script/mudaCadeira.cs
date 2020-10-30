using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mudaCadeira : MonoBehaviour
{

    public GameObject[] cadeiras = new GameObject[6];
    public Material text_cadeira;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider other){
        
        for(int i=0; i<cadeiras.Length; i++){
        cadeiras[i].GetComponent<Renderer>().material = text_cadeira;
        }
    }
}
