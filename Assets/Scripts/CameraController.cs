using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField]
    private float moveSpeed = 0.5f;

    [SerializeField]
    private float scrollSpeed = 100f;

    private float _horizontalInput;
    private float _verticalInput;
    private float _wheelInput;

    void Update()
    {
        _horizontalInput = Input.GetAxisRaw("Horizontal");
        _verticalInput = Input.GetAxisRaw("Vertical");
        _wheelInput = Input.GetAxis("Mouse ScrollWheel");
    }

    void FixedUpdate()
    {
        if (_horizontalInput != 0 || _verticalInput != 0)
        {
            transform.position += moveSpeed * new Vector3(_horizontalInput, 0, _verticalInput);
        }

        if (_wheelInput != 0)
        {
            transform.position += scrollSpeed * new Vector3(0, -_wheelInput, 0);
        }
    }
}
