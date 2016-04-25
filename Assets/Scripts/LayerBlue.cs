using UnityEngine;
using System.Collections;
using DG.Tweening;
public class LayerBlue : Layer {

	// Use this for initialization
	void Start () {
        color = 0;
        isActive = true;
        isRepaired = true;
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            EnableLayer(this.GetComponent<SpriteRenderer>(), isActive);
            isActive = !isActive;
        }
	}
}
