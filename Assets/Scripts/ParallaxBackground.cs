using UnityEngine;

public class ParallaxBackground : MonoBehaviour
{

    [SerializeField] private float moveSpeed;//安全又可编辑
    float backgroundImageWidth;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Sprite sprite = GetComponent<SpriteRenderer>().sprite;
        backgroundImageWidth = sprite.texture.width / sprite.pixelsPerUnit; // 1940/100=19.4
        
    }

    // Update is called once per frame
    void Update()
    {
        float moveX = moveSpeed * Time.deltaTime;
        transform.position += new Vector3(moveX, 0);
        if (Mathf.Abs(transform.position.x) - backgroundImageWidth> 0)
        {
            transform.position = new Vector3(0f, transform.position.y);
        }
    }
}
