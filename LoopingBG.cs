using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoopingBG : MonoBehaviour
{
    public float speed;
    public Renderer BgRenderer;

    // Update is called once per frame
    void Update()
    {
        BgRenderer.material.mainTextureOffset += new Vector2(speed * Time.deltaTime, 0);
    }
}
