using System.Collections;
using UnityEngine;

public class Player : MonoBehaviour
{

    public float moveSpeed = 3;
    public float leftRightSpeed = 4;
    
    void Start()
    {
    }

    private void OnTriggerEnter(Collider collision) 
    {
        if(collision.tag == "blueObj") {
            GenerateLevel.scoreCount++;
            collision.gameObject.SetActive(false);
;
        }

        if(collision.gameObject.CompareTag ("redObj")) {
            GenerateLevel.scoreCount--;
            collision.gameObject.SetActive(false);
        }
        
    }
    void Update()
    {
        transform.Translate(- Vector3.forward * Time.deltaTime * moveSpeed, Space.World);

        if(Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow)) {
                transform.Translate(- Vector3.left * Time.deltaTime * leftRightSpeed);
        }
        
        
        if(Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow)) {            
                transform.Translate(Vector3.left * Time.deltaTime * leftRightSpeed);
        }
    }
      
    
    
        

       
}