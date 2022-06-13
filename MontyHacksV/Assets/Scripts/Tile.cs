using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour
{
    [SerializeField] private Color _baseColor;
    [SerializeField] private SpriteRenderer _sprite;
    [SerializeField] private GameObject _highlight;

    public void Init(bool isOffset){
        
        _sprite.color = isOffset ? new Color(0.6f,0.6f,0.6f,1f) : new Color(255f,255f,255f,1f);
    }

    private void OnMouseEnter() {
        _highlight.SetActive(true);
    }

    private void OnMouseExit() {
        _highlight.SetActive(false);
    }
    
}
