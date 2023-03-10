using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdhesiveBlock : BloqueBase
{
 
    public override void Interaction(PlayableBlock playableBlock)
    {
        GameObject block = playableBlock.gameObject;
        block.transform.localPosition = new Vector2(transform.localPosition.x, transform.localPosition.y*5);
       /* Rigidbody2D blockRB = block.GetComponent<Rigidbody2D>();
        blockRB.velocity = Vector3.zero;*/
    }
}
