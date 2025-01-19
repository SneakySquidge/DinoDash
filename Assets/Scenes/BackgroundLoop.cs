using UnityEngine;

public class BackgroundLoop : MonoBehaviour
{
    [Range(-1f,1f)]
    public float scrollSpeed = 5f;
    private float offset;
    private Material mat;

    void Start()
    {
        mat = GetComponent<Renderer>().material;
    }

    void Update()
    {
        offset += (Time.deltaTime * scrollSpeed) / 30f;
        mat.SetTextureOffset("_MainTex", new Vector2(offset, 0));
    }
}
