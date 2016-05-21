using UnityEngine;
using System.Collections;
using DG.Tweening;
public class LayerGreen : Layer {

	// Use this for initialization
	void Start () {
        color = 1;
        isActive = true;
        isRepaired = true;
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            EnableLayer(this.GetComponent<SpriteRenderer>(), isActive);
            isActive = !isActive;
        }
    }

    
}
