using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Walk2 : MonoBehaviour
{
    public Transform target;
    private bool facingRight=false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float step=Time.deltaTime;
        transform.position=Vector3.MoveTowards(transform.position,target.position,step);
        if (target.position.x>transform.position.x && !facingRight){
            Flip();
        }
        else if(target.position.x<transform.position.x && facingRight){
            Flip();
        }   

    }
        void Flip(){
        facingRight=!facingRight;
        Vector3 theScale=transform.localScale;
        theScale.x*=-1;
        transform.localScale=theScale;
    }
}
