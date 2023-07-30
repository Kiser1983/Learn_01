using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlarmClick : MonoBehaviour
{

    private Animator _animator; 

    void Start()
    {
        _animator = GetComponent<Animator>();
    }

    private void OnMouseDown()
    {
        _animator.SetTrigger("Alarm");
    }

}
