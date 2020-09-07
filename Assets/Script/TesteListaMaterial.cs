using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TesteListaMaterial : MonoBehaviour
{
    public int IndicePorta;
    public GameObject[] gmBloco = new GameObject[15];
    public GameObject obj_chao;
    public GameObject obj_madeira;
    public Material[] TransfText_parede = new Material [2];
    public Material[] TransfText_chao = new Material [2];
    public Material[] TransfText_madeira = new Material [2];
        void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    

    void OnTriggerEnter(Collider other){
        
        for(int i=0; i<gmBloco.Length; i++){
        gmBloco[i].GetComponent<Renderer>().material = TransfText_parede[IndicePorta];
        }
        obj_chao.GetComponent<Renderer>().material = TransfText_chao [IndicePorta];
        obj_madeira.GetComponent<Renderer>().material = TransfText_madeira [IndicePorta];
    }
        
}
