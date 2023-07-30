using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeyPointMovement : MonoBehaviour
{
    [SerializeField] private GameObject Template;
    [SerializeField] private Transform _path;
    [SerializeField] private float _speed;

    private Transform transformNewObject;
    private Transform[] _points;
    private int _currentPoint;
   //private Transform target;

    private void Start()
    {
        GameObject newObject = Instantiate(Template, new Vector3(0, 0, 0), Quaternion.identity);

        transformNewObject = newObject.GetComponent<Transform>();

        _points = new Transform[_path.childCount];

        for (int i = 0; i < _path.childCount; i++)
        {
            _points[i] = _path.GetChild(i);
        }
    }

    private void Update()
    {
        Transform target = _points[_currentPoint];

        //  var direction = (target.position - transform.position).normalized;

        transformNewObject.position = Vector3.MoveTowards(transformNewObject.position, target.position, _speed * Time.deltaTime);

        if (transformNewObject.position == target.position)
        {
            _currentPoint++;

            if (_currentPoint >= _points.Length)
            {
                _currentPoint = 0;
            }
        }
    }

}
