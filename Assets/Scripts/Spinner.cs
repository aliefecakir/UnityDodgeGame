using UnityEngine;

public class Spinner : MonoBehaviour
{
    [SerializeField] float xAngle = 0;
    [SerializeField] float yAngle = 1.3f;
    [SerializeField] float zAngle = 0;

    void Start()
    {
        
    }

    void Update()
    {
        transform.Rotate(xAngle,yAngle,zAngle);
    }
}
