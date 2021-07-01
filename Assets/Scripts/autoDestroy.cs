using UnityEngine;

public class autoDestroy : MonoBehaviour
{
    public float destroyAfter = 2;

    void Start()
    {
        Destroy(gameObject, destroyAfter);
    }
}
