using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Walk : MonoBehaviour
{
    public float speed=5.0f;
    private bool facingRight=true;

    // Update is called once per frame
    void Update()
    {
        float moveHorizontal=Input.GetAxis("Horizontal");
        Vector3 movement=new Vector3(moveHorizontal,0.0f,0.0f);
        transform.position=transform.position+movement*speed*Time.deltaTime;
        if(moveHorizontal>0 && !facingRight){
            Flip();
        }
        else if(moveHorizontal<0 && facingRight){
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
