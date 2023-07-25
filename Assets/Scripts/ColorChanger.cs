using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChanger : MonoBehaviour
{
    [HideInInspector] public SpriteRenderer target;

    [SerializeField] private float _duration;

    private void Start()
    {
        target = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        
    }
}
