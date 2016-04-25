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

        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, 0.0f);
        if (Input.GetKey(KeyCode.D))
        {
            this.transform.DOMove(new Vector3(1, 0, 0), 1);
        }
	}
}
