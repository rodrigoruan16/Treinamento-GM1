using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    Rigidbody2D _rb;

    public void Initialize(float speed)
    {
        _rb.AddForce(Vector3.left * 5f * speed, ForceMode2D.Impulse);
    }

    void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
