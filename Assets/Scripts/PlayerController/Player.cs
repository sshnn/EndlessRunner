using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{

    public float moveSpeed = 3;
    public float leftRightSpeed = 4;
    
    Vector3 gravityVec;
    CharacterController controller;
    Animator playerAnim;
    public static int greenScore = 0;
    public static int redScore = 0;


    void Start()
    {
        controller = GetComponent<CharacterController>();
        playerAnim = GetComponent<Animator>();
    }
    
    void Update()
    {
        keyControl();
        addGravity();
        fall();
    }
      
    
    void keyControl()
    {
        
        controller.Move(- Vector3.forward * Time.deltaTime * moveSpeed);

        if(Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow)) {
                controller.Move(- Vector3.left * Time.deltaTime * leftRightSpeed);
        }
        
        
        if(Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow)) {            
                controller.Move(Vector3.left * Time.deltaTime * leftRightSpeed);
        }
    }

    private void OnTriggerEnter(Collider collision) 
    {
        if(collision.tag == "greenObj") {
            greenScore++;
            collision.gameObject.SetActive(false);
        }

        if(collision.tag =="redObj") {
            redScore++;
            collision.gameObject.SetActive(false);
        }

        if(collision.tag =="obstacle") {
            GenerateLevel.gameOver = true;
            stopAnim();
            StartCoroutine(ScoreTxt.printTotalScore());
        
        }
    }
    

    void addGravity()
    {
         gravityVec = Vector3.zero;
 
         if (controller.isGrounded == false)
         {
             gravityVec += Physics.gravity;
         }
         controller.Move(gravityVec * Time.deltaTime );
    }
    
    void fall()
    {
        if(transform.position.y < 2) {
            GenerateLevel.gameOver = true;
            stopAnim();
            StartCoroutine(ScoreTxt.printTotalScore());
        }
    }      

    void stopAnim()
    {
        moveSpeed = 0;
        leftRightSpeed = 0;
        playerAnim.enabled = false;
    }
}