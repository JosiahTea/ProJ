using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brush : MonoBehaviour
{
    [SerializeField] private float _alphaDecreaseAmount = 0.1f;
    [SerializeField] private List<Trash> _trash;
    [SerializeField] private Canvas _canvas;

    private void Start()
    {
        _canvas.gameObject.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.TryGetComponent(out Trash trash))
        {
            SpriteRenderer spriteRenderer = trash.gameObject.GetComponent<SpriteRenderer>();
            Color color = spriteRenderer.color;
            color.a = Mathf.Max(color.a - _alphaDecreaseAmount, 0);

            spriteRenderer.color = color;


            if(color.a <= 0)
            {
                Destroy(trash.gameObject);
                _trash.Remove(trash);
                CheckClean();
            }
        }
    }

    private void CheckClean()
    {
        if(_trash.Count == 0)
        {
            _canvas.gameObject.SetActive(true);

            gameObject.SetActive(false);
        } 
    }
}
