using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Shape : MonoBehaviour
{
    [SerializeField] protected TMP_Text text;
    [SerializeField] protected new string name;

    protected GameObject mainManager;

    private void Start()
    {
        mainManager = GameObject.Find("MainManager");
    }

    // Encapculation
    public string _name
    {
        get { return name; }
        private set { name = value; }
    }

    public string _username { get; set; } 
    public Color color { get; set; }

    public virtual void Greet()
    {
        SetTextColor();
        _username = mainManager.GetComponent<MainManager>().username;
        text.text = $"{_name}: Hello, {_username}. Glad to meet you.";
    }

    // Abstraction
    public void SetTextColor()
    {
        color = this.GetComponent<MeshRenderer>().material.color;
        text.color = color;
    }

    public void OnMouseDown()
    {
        Greet();
    }
}
