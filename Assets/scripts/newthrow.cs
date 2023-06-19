using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class newthrow : MonoBehaviour
{
    private Vector3 pos;
    private Quaternion rot;

    

    public GameObject marb;
    public GameObject Player1;
    public GameObject Player2;
    public GameObject buttoncnf;
    public ConfirmLP clp;

    private void Start()
    {
        pos = transform.position;
        rot = transform.rotation;
        clp = buttoncnf.GetComponent<ConfirmLP>();
      
       
    }
    GameObject g;
    public void ResetThrow()
    {
        clp.ballnumber=1;
        clp.UnConfrmed();
        
    }
   
    public void newThrow()
    {
        //Debug.Log("red ");
        
       g =  Instantiate(Player1, pos, rot );
        g.transform.SetParent(marb.transform);
        g.transform.tag = "red";
        
    }
    
   
  // public void blueThrow()
  // {
  //     Debug.Log("blue ");
  //  
  //     GameObject p2 = Instantiate(Player2,pos, rot );
  //     p2.transform.SetParent(marb.transform);
  //     
  //     
  // }


}
