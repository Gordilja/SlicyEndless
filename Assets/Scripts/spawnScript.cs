using UnityEngine;

public class spawnScript : MonoBehaviour
{
    public GameObject[] fruits;

    private void Start()
    {
        InvokeRepeating("generate", 1, 1);
    }

    public void generate()
    {
        if (GameManager.gameManager.canGenerateFruit)
        {
            int rand = Random.Range(0, fruits.Length);
            Instantiate(fruits[rand], transform.position, fruits[rand].transform.rotation);
        }
    }
}
