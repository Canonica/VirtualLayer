using UnityEngine;
using System.Collections;
using DG.Tweening;
public class Layer : MonoBehaviour {

    public int color;
    public bool isRepaired;
    public bool isActive;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void EnableLayer(SpriteRenderer sprite, bool isActive)
    {
        if (isRepaired)
        {
            if (isActive)
            {
                sprite.DOFade(0.2f, 1.0f);
                isActive = false;
            }
            else
            {
                sprite.DOFade(1f, 1.0f);
                isActive = true;
            }
        }
    }
}
