using UnityEngine;

public class SprietSorter : MonoBehaviour
{
    [Header("Elements ")]
    [SerializeField] private SpriteRenderer spriteRenderer;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Taking two values into consideration while sorting sprites of the arena
        spriteRenderer.sortingOrder = -1 * (int)(transform.position.y * 10); 
    }
}
