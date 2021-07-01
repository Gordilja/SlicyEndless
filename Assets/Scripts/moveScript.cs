using UnityEngine;

public class moveScript : MonoBehaviour
{
    private int speed = 10;

    void Update()
    {
        transform.Translate(Vector3.left * Time.deltaTime * speed);
        if (transform.position.z > 50 || transform.position.y < -2)
        {
            Destroy(gameObject);
        }
    }
}
