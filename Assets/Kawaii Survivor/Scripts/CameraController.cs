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
        
        // Clamping camera target position with minX maxX and minY and maxY
        
        targetPosition.x = Mathf.Clamp(targetPosition.x, -minMaxXY.x, minMaxXY.x);
        targetPosition.y = Mathf.Clamp(targetPosition.y, -minMaxXY.y, minMaxXY.y);
        
        transform.position = Vector3.Lerp(transform.position, targetPosition, 0.1f);    
    }
}