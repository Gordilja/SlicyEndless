using UnityEngine;
using TMPro;

public class KnifeControl : MonoBehaviour
{
    public Animator animator;
    public Sliceable slice;
    public bool move;
    public TextMeshProUGUI scoretxt;
    int score;

    private void Start()
    {
        scoretxt.text = score.ToString();
    }

    private void Update()
    {
        
        if ((Input.GetKeyDown(KeyCode.Mouse0)) && move)
        {
            animator.SetBool("cut", true);

        } else if((Input.GetKeyUp(KeyCode.Mouse0)) || move == false)
        {
            animator.SetBool("cut", false);
        }
       
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Obstacle")
        {
            Debug.Log("Game Over");
            move = false;
            FindObjectOfType<GameManager>().gameOver();
        }
        else if(other.gameObject.tag != "Obstacle")
        {
            score++;
            scoretxt.text = score.ToString();
        }     
    }
}


