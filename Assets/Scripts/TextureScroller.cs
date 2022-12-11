using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextureScroller : MonoBehaviour
{
    [SerializeField] float _speed;

    Material _material;

    void Start()
    {
        SpriteRenderer renderer = GetComponent<SpriteRenderer>();
        _material = renderer.material;
    }

    void Update()
    {
        Vector2 offset = _material.mainTextureOffset;
        offset.x += _speed * Time.deltaTime;
        if (offset.x > 1f)
        {
            offset.x -= 1f;
        }
        _material.mainTextureOffset = offset;
    }
}
