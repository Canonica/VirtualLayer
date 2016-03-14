using UnityEngine;
using System.Collections;
using DG.Tweening;

public class LayerManager : MonoBehaviour {

    public SpriteRenderer[] layer1;
    public bool isLayer1;
	// Use this for initialization
	void Start () {
        isLayer1 = false;
        for (int i = 0; i < layer1.Length; i++)
        {
            layer1[i].DOFade(0.2f, 1.0f);
        }
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            enableLayer(layer1, isLayer1);
        }
	}


    public bool enableLayer(SpriteRenderer[] layer, bool isActive)
    {
        if (layer.Length>0)
        {
            for (int i = 0; i < layer.Length; i++)
            {
                if (isActive)
                {
                    layer[i].DOFade(0.2f, 1.0f);
                    isActive = false;
                }
                else
                {
                    layer[i].DOFade(1f, 1.0f);
                    isActive = true;
                }
            }
        }
        return isActive;
    }
}
