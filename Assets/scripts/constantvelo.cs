using UnityEngine;
using UnityEngine.UI;

public class constantvelo : MonoBehaviour
{
    public Transform target; // The target position to throw the ball towards
    public float throwSpeed = 20f; // The speed at which the ball is thrown

    private Rigidbody ballRigidbody;
    private newthrow n;
    
    //----------------------------------ui-------
    public int marbles=18;
    public int chances = 0;
    public int score = 0;
    public GameObject endscreen;
    public Text Played;
    
    //--------------------------------
    private void Start()
    {
        ballRigidbody = GetComponent<Rigidbody>();
        n = GetComponent<newthrow>();
       

    }
    private void Update()
    {
        if (Input.GetKey("escape"))
        {
            Application.Quit();
        }
        if (marbles == 0)
        {

            Invoke(nameof(showendscreen), 1f);
        }
        updatechances();
    }
    private void showendscreen()
    {
        endscreen.SetActive(true);
        //win.PlayOneShot(wining);
    }
    void updatechances()
    {
        Played.text = "" + chances;
    }
    private void OnMouseDown()
    {
        ThrowToTarget();
   }
   private void OnMouseUp()
   {
        n.ResetThrow();
   }

    public Vector3 velocity;
    private void ThrowToTarget()
    {

        // Calculate the direction from the ball's position to the target position
        Vector3 direction = target.position - transform.position;

        // Calculate the time it takes for the ball to reach the target position
        float time = direction.magnitude / throwSpeed;

        // Calculate the initial velocity required to reach the target position
       velocity = direction / time;

        // Apply the velocity to the ball
        ballRigidbody.velocity = velocity;
        chances++;
    }
}