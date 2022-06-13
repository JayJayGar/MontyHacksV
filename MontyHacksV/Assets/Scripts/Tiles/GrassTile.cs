using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrassTile : Tile
{
    
    public override void Init(int x, int y){
        
        var isOffset = (x+y) % 2 == 1;
        _sprite.color = isOffset ? new Color(0.6f,0.6f,0.6f,1f) : new Color(255f,255f,255f,1f);
    }
}
