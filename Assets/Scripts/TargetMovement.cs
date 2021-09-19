using UnityEngine;

public class TargetMovement : MonoBehaviour
{
    public float range;
    public float speed;
    private int dir = 1;

    void Update()
    {
        if (transform.position.z < -range || 
            transform.position.z > range)
        {
            dir = -dir;
        }
        Vector3 pos = transform.position;
        pos.z += dir * speed * Time.deltaTime;
        transform.position = pos;
    }
}
