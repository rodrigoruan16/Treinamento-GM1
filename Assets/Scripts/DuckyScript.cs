using UnityEngine;
using UnityEngine.InputSystem;

public class DuckyScript : MonoBehaviour
{
    Rigidbody2D _rb;

    void OnTriggerEnter2D(Collider2D _collision)
    {
        PlayerPrefs.Save();
        Destroy(transform.gameObject);
        EndApplication();
    }

    void OnQuit()
    {
        PlayerPrefs.Save();
        EndApplication();
    }

    void EndApplication()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
                Application.Quit();

#endif
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    private void OnJump(InputValue inputValue)
    {
        _rb.AddForce(Vector3.up * 3f, ForceMode2D.Impulse);
    }

    void FixedUpdate()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
