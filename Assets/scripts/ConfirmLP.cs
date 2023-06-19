using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ConfirmLP: MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject landingpt;
    public Image landingimage;
    public GameObject line;
    public GameObject arcandarrow;
    public GameObject player;
    public int ballnumber=0;
    public newthrow n;
    void Awake()
    {
        arcandarrow.SetActive(false);
        player.SetActive(false);
        landingimage = landingpt.GetComponent<Image>();
    }
    public void Confrmed()
    {
        arcandarrow.SetActive(true);
        if (ballnumber == 0)
        {
            player.SetActive(true);
        }
        landingimage.enabled = false;
        line.SetActive(false);
        gameObject.SetActive(false);

        if(ballnumber > 0)
        {
            n.newThrow();
        }
    }
    public void UnConfrmed()
    {
        ballnumber = 1;
        Invoke(nameof(reset), 3f);

    }
    private void reset()
    {
        arcandarrow.SetActive(false);
       
        landingimage.enabled = true;
        line.SetActive(true);
        gameObject.SetActive(true);
    }


}
