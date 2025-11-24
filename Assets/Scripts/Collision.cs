using UnityEngine;
using UnityEngine.UI;

public class Collision : MonoBehaviour
{
    [SerializeField] float safeLandingSpeed;
    [SerializeField] GameObject winText;
    [SerializeField] GameObject loseText;
    [SerializeField] GameObject restartText;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        float speed = collision.relativeVelocity.magnitude;

        if (collision.collider.CompareTag("Obstacle"))
        {
            Lose();
            Debug.Log("CRASHED INTO OBSTACLE!");
            return;
        }

        if (collision.collider.CompareTag("Ground"))
        {
            if (speed < safeLandingSpeed)
            {
                Win();
                Debug.Log("SAFE LANDING!");
            }
            else
            {
                Lose();
                Debug.Log("HARD LANDING – CRASH!");
            }
        }
    }

    private void Win()
    {
        winText.SetActive(true);
        restartText.SetActive(true);
        GetComponent<Forces>().enabled = false;
    }
    
    private void Lose()
    {
        loseText.SetActive(true);
        restartText.SetActive(true);
        GetComponent<Forces>().enabled = false;
    }

}
