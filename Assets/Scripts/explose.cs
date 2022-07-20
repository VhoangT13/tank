using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class explose : MonoBehaviour
{
    [SerializeField] AudioClip clip;
    // Start is called before the first frame update
    void Start()
    {
        scoreScript.scoreVal+= 10;
        SoundManagerScript.Instance.PlaySound(clip);
        Destroy(gameObject,0.4f);
    }

    // Update is called once per frame
    void Update()
    {
    }
}
