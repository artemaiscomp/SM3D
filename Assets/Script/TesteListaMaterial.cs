using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TesteListaMaterial : MonoBehaviour
{
    public int IndicePorta;
    public GameObject[] gmBloco = new GameObject[15];
    public GameObject[] objParedes = new GameObject[16];
    public GameObject obj_chao;
    public GameObject obj_madeira;
    public GameObject obj_janela;
    public GameObject[] obj_elevador = new GameObject[2];
    public GameObject obj_pedregulho;
    public Material[] TransfText_parede = new Material[8];
    public Material[] TransfText_Muro = new Material[8];
    public Material[] TransfText_chao = new Material[8];
    public Material[] TransfText_madeira = new Material[8];
    public Material[] TransfText_janela = new Material[8];
    public Material[] TransfText_elevador = new Material[8];
    public Material[] TransfText_pedras = new Material[8];

    //Change text Variable
    public Text txtMonolith;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }


    void OnTriggerEnter(Collider other)
    {

        for (int i = 0; i < gmBloco.Length; i++)
        {
            gmBloco[i].GetComponent<Renderer>().material = TransfText_parede[IndicePorta];
        }
        for (int i = 0; i < obj_elevador.Length; i++)
        {
            obj_elevador[i].GetComponent<Renderer>().material = TransfText_elevador[IndicePorta];
        }
        for (int i = 0; i < objParedes.Length; i++)
        {
            objParedes[i].GetComponent<Renderer>().material = TransfText_Muro[IndicePorta];
        }

        obj_chao.GetComponent<Renderer>().material = TransfText_chao[IndicePorta];
        obj_madeira.GetComponent<Renderer>().material = TransfText_madeira[IndicePorta];
        obj_pedregulho.GetComponent<Renderer>().material = TransfText_pedras[IndicePorta];
        obj_janela.GetComponent<Renderer>().material = TransfText_janela[IndicePorta];

        //Change Text

        switch (other.name)
        {
            case "FPSController":
                txtMonolith.text = "Entrou na porta da Noite estrelada, parabéns, doido";
                break;
            default:
                txtMonolith.text = "Outra porta qualquer";
                break;
        }
    }

}
