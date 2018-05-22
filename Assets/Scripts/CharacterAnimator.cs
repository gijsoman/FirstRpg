using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class CharacterAnimator : MonoBehaviour
{
    public float LocomotionAnimationSmoothTime = .1f;

    private Animator animator;
    private NavMeshAgent agent;

	private void Start ()
    {
        animator = GetComponentInChildren<Animator>();
        agent = GetComponent<NavMeshAgent>();
	}
	
	private void Update ()
    {
        float speedPercent = agent.velocity.magnitude / agent.speed;
        animator.SetFloat("speedPercent", speedPercent, LocomotionAnimationSmoothTime, Time.deltaTime);
	}
}
