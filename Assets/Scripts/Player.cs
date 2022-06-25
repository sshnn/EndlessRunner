using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{

    public float moveSpeed = 3;
    public float leftRightSpeed = 4;
    



     Vector3 gravityVec;
     CharacterController controller;
 




    void Start()
    {
        controller = GetComponent<CharacterController>();

    }

    
    void Update()
    {
        keyControl();
        addGravity();
        StartCoroutine(fall());
       
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
        if(collision.tag == "blueObj") {
            GenerateLevel.scoreCount++;
            collision.gameObject.SetActive(false);
;
        }

        if(collision.tag =="redObj") {
            GenerateLevel.scoreCount--;
            collision.gameObject.SetActive(false);
        }

        if(collision.tag =="obstacle") {
            collision.gameObject.SetActive(false);
            SceneManager.LoadScene(0);

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
    
    IEnumerator fall()
    {
        if(transform.position.y < 2) {
            yield return new WaitForSeconds(1);
            SceneManager.LoadScene(0);
        }
    }      
}