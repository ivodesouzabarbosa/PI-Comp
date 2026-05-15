using UnityEngine;
using UnityEngine.EventSystems;

public class Lado : MonoBehaviour
{
    public Transform target;
    public float rotateSpeed = 100f;

    bool left;
    bool right;

    void Update()
    {
        if (left)
            target.Rotate(Vector3.up * -rotateSpeed * Time.deltaTime);

        if (right)
            target.Rotate(Vector3.up * rotateSpeed * Time.deltaTime);
    }

    public void LeftDown()
    {
        left = true;
    }

    public void LeftUp()
    {
        left = false;
    }

    public void RightDown()
    {
        right = true;
    }

    public void RightUp()
    {
        right = false;
    }
}