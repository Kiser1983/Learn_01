using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChangeCharacter : MonoBehaviour
{
    private Color startColor;
    public Color endColor;
    public float duration = 2f;

    private Renderer characterRenderer;
    private SpriteRenderer characterSpriteRenderer;

    private void Start()
    {
        characterRenderer = GetComponent<Renderer>();
        characterSpriteRenderer = GetComponent<SpriteRenderer>();
        startColor = characterSpriteRenderer.color;
        StartCoroutine(ChangeColor());
    }

    private IEnumerator ChangeColor()
    {
        while (true)
        {
            float t = 0f;
            while (t < 1f)
            {
                t += Time.deltaTime / duration;
                characterSpriteRenderer.color = Color.Lerp(startColor, endColor, t);
                yield return null;
            }

            yield return new WaitForSeconds(0.5f); 

            t = 0f;
            while (t < 1f)
            {
                t += Time.deltaTime / duration;
                characterSpriteRenderer.color = Color.Lerp(endColor, startColor, t);
                yield return null;
            }

            yield return new WaitForSeconds(0.5f); 
        }
    }
}
