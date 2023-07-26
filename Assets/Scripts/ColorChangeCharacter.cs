using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChangeCharacter : MonoBehaviour
{
    public Color startColor;
    public Color endColor;
    public float duration = 2f;

    private Renderer characterRenderer;

    private void Start()
    {
        characterRenderer = GetComponent<Renderer>();
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
                characterRenderer.material.color = Color.Lerp(startColor, endColor, t);
                yield return null;
            }

            yield return new WaitForSeconds(0.5f); // Optional delay before changing back

            t = 0f;
            while (t < 1f)
            {
                t += Time.deltaTime / duration;
                characterRenderer.material.color = Color.Lerp(endColor, startColor, t);
                yield return null;
            }

            yield return new WaitForSeconds(0.5f); // Optional delay before changing color again
        }
    }
}
