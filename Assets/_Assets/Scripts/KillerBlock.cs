using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillerBlock : BloqueBase
{
    public override void Interaction(PlayableBlock playableBlock)
    {
        playableBlock.gameObject.SetActive(false);
    }
}
