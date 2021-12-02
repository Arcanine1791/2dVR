using UnityEngine;
using UnityEngine.Events;

public class Player : MonoBehaviour
{
    public float RotateSpeed = 30f;
    public GameObject target;
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
            target.transform.Rotate(-Vector3.forward * RotateSpeed * Time.deltaTime);
        else if (Input.GetKey(KeyCode.RightArrow))
            target.transform.Rotate(Vector3.forward * RotateSpeed * Time.deltaTime);
    }
}
