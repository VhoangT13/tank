using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManagerScript : MonoBehaviour
{
   public static SoundManagerScript Instance;
   [SerializeField]
   private AudioSource audioSource;

   void Awake(){
       if (Instance == null){
           Instance = this;
           DontDestroyOnLoad(gameObject);
       }else{
           Destroy(gameObject);
       }
   }

   public void PlaySound(AudioClip clip){
        audioSource.PlayOneShot(clip,0.3f);
   }
}
