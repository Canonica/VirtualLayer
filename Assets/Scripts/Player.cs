using UnityEngine;
using System.Collections;
using DG.Tweening;

public class Player : MonoBehaviour {

    bool canMove;
    bool canJump;

    public float speed;
    Vector3 movement;
	// Use this for initialization
	void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {

        
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += new Vector3(1, 0, 0) * 5f  * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.Q))
        {
            transform.position += new Vector3(-1, 0, 0) * 5f * Time.deltaTime;
        }
        if (Input.GetKeyDown(KeyCode.Z) )
        {
            this.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 8), ForceMode2D.Impulse);
            
        }
    }
}
