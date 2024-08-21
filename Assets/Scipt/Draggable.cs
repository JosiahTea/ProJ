using UnityEngine;

public class Draggable : MonoBehaviour
{
    private bool _isDragging = false;
    private Vector3 _offset;

    void OnMouseDown()
    {
        _isDragging = true;
        _offset = transform.position - GetMouseWorldPos();
    }

    void OnMouseUp()
    {
        _isDragging = false;
    }

    void Update()
    {
        if (_isDragging)
        {
            transform.position = GetMouseWorldPos() + _offset;
        }
    }

    private Vector3 GetMouseWorldPos()
    {
        // ѕолучаем позицию мыши в мировых координатах
        Vector3 mousePoint = Input.mousePosition;
        mousePoint.z = Camera.main.WorldToScreenPoint(transform.position).z;

        return Camera.main.ScreenToWorldPoint(mousePoint);
    }
}