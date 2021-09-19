using UnityEngine;

public class UserControl : MonoBehaviour
{
    private Rigidbody rigidbody;
    
    private int dir;
    public float netForce;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
            dir = 1;
        else if (Input.GetKey(KeyCode.D))
            dir = -1;
        else
            dir = 0;
    }

    void FixedUpdate()
    {
        rigidbody.AddForce(0, 0, -dir * netForce * Time.fixedDeltaTime);
    }
}
