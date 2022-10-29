using System;
using System.Net.Mime;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class MainMenu : MonoBehaviour
{
    [SerializeField] private Button buttonUp_curr;
    [SerializeField] private Button buttonDown_curr;
    [SerializeField] private TextMeshProUGUI text_curr;

    private String code;

    [SerializeField] private TextMeshProUGUI num1;
    [SerializeField] private TextMeshProUGUI num2;
    [SerializeField] private TextMeshProUGUI num3;
    [SerializeField] private TextMeshProUGUI num4;
    [SerializeField] private TextMeshProUGUI num5;
    [SerializeField] private TextMeshProUGUI num6;

    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void IncreaseNum()
    {
        SetButton();
        if (int.Parse(text_curr.text) < 9)
        {
            buttonUp_curr.interactable = true;
            text_curr.text = (int.Parse(text_curr.text) + 1).ToString();
        }
        SetButton();
    }

    public void DecreaseNum()
    {
        SetButton();
        if (int.Parse(text_curr.text) > 0)
        {
            buttonUp_curr.interactable = true;
            text_curr.text = (int.Parse(text_curr.text) - 1).ToString();
        }
        SetButton();

    }

    void SetButton()
    {
        if (int.Parse(text_curr.text) == 9)
        {
            buttonUp_curr.interactable = false;
        } else
        {
            buttonUp_curr.interactable = true;
        }
        if (int.Parse(text_curr.text) == 0)
        {
            buttonDown_curr.interactable = false;
        } else
        {
            buttonDown_curr.interactable = true;
        }
    }

    void Start()
    {
        if (buttonDown_curr != null && buttonUp_curr != null)
        {
            SetButton();
        }
    }

    public void SaveCode()
    {
        code = num1.text + num2.text + num3.text + num4.text + num5.text + num6.text;
        Debug.Log(code);
    }
}
