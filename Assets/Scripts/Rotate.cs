using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    private Rigidbody _rb;
    [SerializeField] private float _timer = 5f;
    [SerializeField] private Vector3 _torque;
    
    private void Awake() {
        _rb = GetComponent<Rigidbody>();
    }

    private void Start() {
        ApplyRandomTorque();
    }

    private void Update() {
        _timer -= Time.deltaTime;
        if(_timer <= 0) {
            _timer = 5f;
            ApplyRandomTorque();
        }
    }

    private void ApplyRandomTorque() {
        _rb.AddTorque(_torque.x * -1, _torque.y * -1, _torque.z + -1);

        var x = Random.Range(-10, 10);
        var y = Random.Range(-10, 10);
        var z = Random.Range(-10, 10);

        _torque = new Vector3(x, y, z);
        _rb.AddTorque(_torque);
    }

    
}
