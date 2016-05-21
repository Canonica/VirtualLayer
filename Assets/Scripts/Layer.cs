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
                sprite.DOFade(0.2f, 0.3f).OnComplete(() => Disable(sprite));
                isActive = false;
            }
            else
            {
                sprite.DOFade(1f, 0.3f).OnComplete(() => Enable(sprite));
                isActive = true;
            }
        }
    }

    void Disable(SpriteRenderer sprite)
    {
        sprite.GetComponent<Collider2D>().enabled = false;
    }

    void Enable(SpriteRenderer sprite)
    {
        sprite.GetComponent<Collider2D>().enabled = true;
    }
}
