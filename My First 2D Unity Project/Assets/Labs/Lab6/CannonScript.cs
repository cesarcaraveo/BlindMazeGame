//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class CannonScript : MonoBehaviour
//{
//    public GameObject cannonBall;

//    // Start is called before the first frame update
//    void Start()
//    {
        
//    }

//    // Update is called once per frame
//    void Update()
//    {

//        Animator anim = GetComponent<Animator>();

//        if (Input.GetKeyDown(KeyCode.R))
//        {
//            anim.SetBool("Shooting", true);
//        }
//    }

//    public void spawnCannonBall(Object obj)
//    {
//        GameObject ball = GameObject.Instantiate<GameObject>(cannonBall);
//        Destroy(ball, 1);
//    }

//    public void switchTransition(Object obj)
//    {
//        Animator anim = GetComponent<Animator>();
//        anim.SetBool("Shooting", false);
//    }
//}
