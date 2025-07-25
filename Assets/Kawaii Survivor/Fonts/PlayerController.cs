using System;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerController : MonoBehaviour
{   
    private Rigidbody2D rig;
    [Header("Elements")]
    [SerializeField]private MobileJoystick playerJoystick;
    
    [Header("Settings")]
    [SerializeField] private float moveSpeed;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
        rig.linearVelocity = Vector2.right;
        moveSpeed = 7;
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void FixedUpdate()
    {
        rig.linearVelocity = playerJoystick.GetMoveVector() * moveSpeed * Time.deltaTime;
    }
}
