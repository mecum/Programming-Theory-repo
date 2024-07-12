using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Shape : MonoBehaviour
{
    [SerializeField] protected TextMeshProUGUI messageText;

    protected Vector4 color;   

    public virtual void OnMouseDown()
    {
        messageText.text = "I am " + GetMyName();
        messageText.color = GetMyColor();
    }

    protected string GetMyName()
    {        
        return gameObject.name;
    }

    public virtual Vector4 GetMyColor()
    {
        color = gameObject.GetComponent<MeshRenderer>().material.color;

        return color;
    }     
}
