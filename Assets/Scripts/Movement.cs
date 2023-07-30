using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public GameObject Player;
    [SerializeField] private float _speed;
    private void Start()
    {
     //   Transform transformPlayer = Player.GetComponent<Transform>();


    }
    private void Update()
    {
        if (Input.GetKey(KeyCode.A) == true)
        { transform.Translate(-1*_speed * Time.deltaTime, 0, 0); }

        if (Input.GetKey(KeyCode.D) == true)
        { transform.Translate(1 * _speed * Time.deltaTime, 0, 0); }
    }
}
