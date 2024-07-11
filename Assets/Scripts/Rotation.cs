using UnityEngine;

public class Rotation : MonoBehaviour
{
    [SerializeField] private float _angleRotationY;

    private void Update()
    {
        transform.Rotate(Vector3.up * _angleRotationY * Time.deltaTime);
    }
}
