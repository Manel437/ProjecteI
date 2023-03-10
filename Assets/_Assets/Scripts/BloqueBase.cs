using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BloqueBase : MonoBehaviour
{
    public abstract void Interaction(PlayableBlock playableBlock);
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "PlayableBlock")
        {
            Interaction(collision.gameObject.GetComponent<PlayableBlock>());
        }
    }
}
