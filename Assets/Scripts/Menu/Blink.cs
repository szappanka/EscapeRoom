using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Blink : MonoBehaviour
{
   [SerializeField] private new AnimationClip animation;
   private Animation animator;


    void Start()
    {
        animator = GetComponent<Animation>();
        InvokeRepeating("PlayAnimation", Random.Range(1.0f, 4.0f), Random.Range(4.0f, 8.0f));
    }

    void PlayAnimation()
    {
        animator.Play(animation.name);
    }

    void Update()
    {
        
    }
}
