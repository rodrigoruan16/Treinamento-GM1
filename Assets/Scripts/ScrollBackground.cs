using System.Collections.Generic;
using UnityEngine;

public class ScrollBackground : MonoBehaviour
{
    private float speed = 1f;
    private float lastTimeMeasure;

    [SerializeField]
    public float Bg1MoveSpeed;

    [SerializeField]
    public float Bg2MoveSpeed;

    [SerializeField]
    public float FloorMoveSpeed;

    [SerializeField]
    public float BushesMoveSpeed;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }

    void updateBackground()
    {
        foreach (Transform child in transform)
        {
            Material material = child.transform.GetComponent<SpriteRenderer>().material;

            Vector2 newMainTextureOffset = new Vector2(material.mainTextureOffset.x, material.mainTextureOffset.y);

            if (child.tag == "Bg1")
            {
                newMainTextureOffset.x += speed * Bg1MoveSpeed * Time.deltaTime;
                material.mainTextureOffset = newMainTextureOffset;
            }
            else if (child.tag == "Bg2")
            {
                newMainTextureOffset.x += speed * Bg2MoveSpeed * Time.deltaTime;
                material.mainTextureOffset = newMainTextureOffset;
            }
            else if (child.tag == "Floor")
            {
                newMainTextureOffset.x += speed * FloorMoveSpeed * Time.deltaTime;
                material.mainTextureOffset = newMainTextureOffset;
            }
            else if (child.tag == "Bushes")
            {
                newMainTextureOffset.x += speed * BushesMoveSpeed * Time.deltaTime;
                material.mainTextureOffset = newMainTextureOffset;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        updateBackground();

        if (Time.time - lastTimeMeasure >= 5f)
        {
            speed = speed * 1.1f;
            lastTimeMeasure = Time.time;
        }
    }
}
