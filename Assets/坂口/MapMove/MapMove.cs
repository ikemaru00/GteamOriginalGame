using UnityEngine;

public class MapMove : MonoBehaviour
{
    public float scrollSpeed = 1.0f;

    private void Update()
    {
        // ”wŒi‚ğƒXƒNƒ[ƒ‹
        float offsetX = Time.time * scrollSpeed;
        GetComponent<Renderer>().material.mainTextureOffset = new Vector2(offsetX, 0);
    }
}
