using UnityEngine;
public class PlayerCollision : MonoBehaviour
{
    public PlayerController playerController;
    public Score score;
    public gameController gameController;
    public AudioSource audioSource;
     public AudioSource audioSource1;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Collectables")
        {
            audioSource.Play();
            score.AddScore();
            Destroy(other.gameObject);
        }
        // Debug .Log (other.gameObject);


    }
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "obstacles")
        {
            audioSource1.Play();
            score.ShowFinalScore();
            gameController.GameOver();
            playerController.enabled = false;
        }
    }


}
