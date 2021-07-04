using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{

    private Vector2 _coordinates;
    private Vector3 _movement;
    private float _speed = 3;
    private PlayerInput _playerInput;

    // Start is called before the first frame update
    void Start()
    {
        _playerInput = gameObject.GetComponent<PlayerInput>();
    }

    // Update is called once per frame
    void Update()
    {
        move();
    }

    public void getVecorCoordinates()
    {
        _coordinates = _playerInput.actions["Move"].ReadValue<Vector2>();
        _movement = new Vector3(_coordinates.x, _coordinates.y, 0);
    }

    void move()
    {
        transform.Translate(_movement * _speed * Time.deltaTime);
    }

}
