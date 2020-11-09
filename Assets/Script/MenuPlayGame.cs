using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuPlayGame : MonoBehaviour
{
    [SerializeField]
    private Button buttonExplicada, buttonLivre;
    public static bool monolithIsTrue = true;

    void Start()
    {
        buttonExplicada.onClick.AddListener(ClickExplicada);
        buttonLivre.onClick.AddListener(ClickLivre);
    }

    void ClickExplicada()
    {
        monolithIsTrue = true;
        SceneManager.LoadScene("bloco");
    }
    void ClickLivre()
    {
        monolithIsTrue = false;
        SceneManager.LoadScene("bloco");
    }
}
