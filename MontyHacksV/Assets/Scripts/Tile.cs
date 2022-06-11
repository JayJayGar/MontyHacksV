using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour
{
    [Serialized] private Color _baseColor, _offsetColor;
    [Serialized] private SpriteRenderer _renderer;
    [Serialized] private GameObject _highlight;

    public void Init(bool isOffset){
        _renderer.Color = isOffset ? _offsetColor:_baseColor;
    }

    void private void OnMouseEnter() {
        _highlight.SetActive(true);
    }

    void private void OnMouseExit() {
        _highlight.SetActive(false);
    }
    
}
