using UnityEngine;

public class AccelTrigger : MonoBehaviour
{
    public Rigidbody player;
    public float netForce;

    void OnTriggerEnter(Collider collider)
    {
        if (collider.tag == "Player")
        {
            Debug.Log("Accel");
            player.AddForce(0, netForce, 0);
        }
    }
}
