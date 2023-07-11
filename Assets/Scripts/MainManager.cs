using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class MainManager : MonoBehaviour
{
    public static MainManager Instance;

    [SerializeField] TMP_InputField usernameInputField;
    public string username { get; private set; }

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    public void GetUsername()
    {
        username = usernameInputField.text.Trim();

        if (username == "")
        {
            username = "some random guy with no name";
        }
    }

    public void EnterMainScene()
    {
        SceneManager.LoadScene(1);
    }
}
