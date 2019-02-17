using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickHandler : MonoBehaviour
{
    Animator anim;
    
    // Start is called before the first frame update
    void Start()
    {
        // Save a reference to the animator object
        anim = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        // When the left mouse button is clicked on this object
        // set a trigger that begins the balloon pop animation
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(ray.origin, ray.direction);
            if (hit && hit.collider.gameObject == gameObject) {
                anim.SetTrigger("Clicked");
            }          
        }

        // Destroy the balloon object when the animation is finished
        AnimatorStateInfo stateInfo = anim.GetCurrentAnimatorStateInfo(0);
        if (stateInfo.IsName("Pop") && stateInfo.normalizedTime >= 0.9f)
        {
            FindObjectOfType<AudioManager>().Play("BalloonPop");
            Destroy(gameObject);
            Score.CurrentScore++;
        }
    }
}
