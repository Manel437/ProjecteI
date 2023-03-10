using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Draggable : MonoBehaviour
{
    public Camera cam;
    public float pushForce;
    
    private PlayableBlock _playableBlock;
    float _distance;
    Vector2 _startPos;
    Vector2 _endPos;
    Vector2 _direction;
    Vector2 _force;

    private void Start()
    {
        _playableBlock = GetComponent<PlayableBlock>();
    }
    private void OnMouseDown()
    {
        _startPos = cam.ScreenToWorldPoint(Input.mousePosition);
    }
    private void OnMouseDrag()
    {
        _endPos = cam.ScreenToWorldPoint(Input.mousePosition);  
        _distance = Vector2.Distance(_startPos, _endPos);
        _direction = (_startPos - _endPos).normalized;
        _force = _direction * _distance * pushForce;

        Debug.DrawLine(_startPos, _endPos, Color.green);
    }
    private void OnMouseUp()
    {
        _playableBlock.rigidbody2D.AddForce(_force, ForceMode2D.Impulse);

    }
}
