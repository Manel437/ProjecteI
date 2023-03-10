using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyableBlock : BloqueBase
{
    public override void Interaction(PlayableBlock playableBlock)
    {
        gameObject.SetActive(false);
    }
}
