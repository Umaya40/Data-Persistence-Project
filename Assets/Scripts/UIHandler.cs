using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

[DefaultExecutionOrder(1000)]
public class UIHandler : MonoBehaviour
{
    public GameObject inputField;
    private TMP_InputField input;

    public void Awake()
    {
        input = inputField.GetComponent<TMP_InputField>();
        UpdateName();
    }
    public void StartNew()
    {
        SceneManager.LoadScene(1);
    }

    public void UpdateName()
    {
        GameManager.gameManager.username = input.text;
    }
}
