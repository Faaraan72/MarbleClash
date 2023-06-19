using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

using UnityEngine.SceneManagement;

public class scoring : MonoBehaviour
{
    constantvelo cv;
    public GameObject player;
    [SerializeField] private AudioSource score;
  
    public Text Score;
   
    //  string tag;
    //int blueScore = 0;
    // int redScore = 0;
     public void Start()
      {
        cv = player.GetComponent<constantvelo>();
        Score.text = "0" ;
       
     }
    private void Update()
    {
      UpdateScore();
    }
   

    private void OnTriggerExit(Collider other)
    {
        score.Play();
       
        cv.marbles--;
        cv.score++;
       // Debug.Log(d.marbles);
        //Debug.Log("" + d.score);
        //Destroy(gameObject, 5f);
       
    }
   public void UpdateScore()
    {
       Score.text = "" + cv.score;
    }


}
