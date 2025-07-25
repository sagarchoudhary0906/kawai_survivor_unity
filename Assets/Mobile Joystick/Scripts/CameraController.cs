using System;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [Header("Elements")]
    [SerializeField] private Transform target;
    
    [Header("Settings")]
    [SerializeField] private Vector2 minMaxXY;
    
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void LateUpdate()
    {
        if (!target)
        {
            return;
        }
        Vector3 targetPosition = target.position;
        targetPosition.z = -10;
        
        // Calmping camer taget posiiton with minX maxX and minY and maxY
        
        targetPosition.x = Mathf.Clamp(targetPosition.x, -minMaxXY.x, minMaxXY.x);
        targetPosition.y = Mathf.Clamp(targetPosition.x, -minMaxXY.y, minMaxXY.y);
        
        transform.position = targetPosition;
    }
}