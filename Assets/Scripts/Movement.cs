using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private float _speedForward;
    [SerializeField] private float _angleRotationY;
    [SerializeField] private float _speedScale;

    private void Update()
    {
        MoveForward();
        Rotate();
        Scale();
    }

    private void MoveForward()
    {
        transform.Translate(Vector3.forward * _speedForward * Time.deltaTime);
    }

    private void Rotate()
    {
        transform.Rotate(Vector3.up * _angleRotationY * Time.deltaTime);
    }

    private void Scale()
    {
        transform.localScale += Vector3.one * _speedScale * Time.deltaTime;
    }
}
