using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChanger : MonoBehaviour
{
    [HideInInspector] public SpriteRenderer target;
    [SerializeField] private float _duration;
    [SerializeField] private Color _targetColor;
    private float _runningTime;
    private Color _statrColor;

    private void Start()
    {
        target = GetComponent<SpriteRenderer>();
        _statrColor = target.color;
    }

    void Update()
    {
        if (_runningTime <= _duration)
        {
            _runningTime += Time.deltaTime;
            float notmalizeRunningTime = _runningTime / _duration;

            // Color newColor = new Color(_targetColor.r * notmalizeRunningTime, _targetColor.g * notmalizeRunningTime, _targetColor.b * notmalizeRunningTime);
            //  target.color = newColor;

            target.color = Color.Lerp(_statrColor, _targetColor, notmalizeRunningTime);
        }

    }
}
