using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 8;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GetComponent<Rigidbody2D>().linearVelocity = new Vector2(0, speed);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
