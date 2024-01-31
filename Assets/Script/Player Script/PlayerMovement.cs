using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
 
   public float movementSpeed = 3f;
   
   private Rigidbody2D myBody;
   private Vector2 moveVector;
   private SpriteRenderer sr; 

   private float harvestTimer;
   private bool isHarvesting;
   private GameObject artifact;
   private int movex,movey;
   private Animator anim;
   private void Awake(){

   myBody=GetComponent<Rigidbody2D>();
   sr=GetComponent<SpriteRenderer>();

  }
  private void Update(){
  FlipSprite();
 
 } 
  private void FixedUpdate(){
 
   if(isHarvesting){
     myBody.velocity=Vector2.zero;
   }else{ 
   moveVector=new Vector2(Input.GetAxis("Horizontal"),Input.GetAxis("Vertical"));
  }
  if(moveVector.sqrMagnitude>1){
      moveVector=moveVector.normalized;
  }
   myBody.velocity=new Vector2(moveVector.x*movementSpeed,moveVector.y*movementSpeed); 
   
}

void FlipSprite(){
 int x=(int)Input.GetAxisRaw("Horizontal");
 
 if(x==1){
    sr.flipX=false;
 }else{
    if(x==-1){
         sr.flipX= true;
     }
  }
  
}

private void OnTriggerEnter2D(Collider2D collision){
 
      if(collision.CompareTag("Bush")){
   
     }
 }

}