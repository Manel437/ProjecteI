using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayableBlock : MonoBehaviour
{
    [HideInInspector] public new Rigidbody2D rigidbody2D;

    private void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
    }
}
