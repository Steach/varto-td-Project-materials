using UnityEngine;

public class StandaloneCamera : MonoBehaviour
{
    [SerializeField] private Transform _gameCamera;
    [SerializeField] private float _moveSpeed;

    private void LateUpdate() 
    {
        float horizontalInput = Input.GetAxisRaw("Horizontal");
        float verticalInput = Input.GetAxisRaw("Vertical");

        Vector3 cameraMoveVector = new Vector3(horizontalInput, 0f, verticalInput).normalized;
        _gameCamera.localPosition += _moveSpeed * Time.deltaTime * cameraMoveVector;
    }
}
