using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Marble : MonoBehaviour
{
    Renderer renderer;

    void Awake()
    {
        renderer = GetComponent<Renderer>();
    }
    public void OnClick()
    {
        ChangeColour();
    }

    public void ChangeColour()
    {
        renderer.material.color = Color.magenta;
    }
}
