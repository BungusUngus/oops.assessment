using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MrFreeze : MonoBehaviour, IClickable
{
    [SerializeField] PhysicMaterial _Material;
    Collider _collider;
    Renderer _renderer;
    Color _ogColor;
    PhysicMaterial _ogMaterial;

    private void Awake()
    {
        _collider = GetComponent<Collider>();
        _renderer = GetComponent<Renderer>();
        _ogColor = _renderer.material.color;
        _ogMaterial = _collider.material;
    }

    public void OnClick()
    {
        if (_collider.material == _ogMaterial)
        {
            _collider.material = _Material;
            _renderer.material.color = Color.cyan;
        }
        else
        {
            _collider.material = _ogMaterial;
            _renderer.material.color _ogColor;
        }
    }
}
