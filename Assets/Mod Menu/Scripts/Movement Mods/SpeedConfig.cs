using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GorillaLocomotion;

public class SpeedConfig : MonoBehaviour
{
	public float speed = 6.5f;
	public float speedMultiplier = 1.1f;

	void OnEnable()
	{
		GorillaLocomotion.Player.Instance.maxJumpSpeed = speed;
		GorillaLocomotion.Player.Instance.jumpMultiplier = speedMultiplier;
	}

	void OnDisable()
	{
		GorillaLocomotion.Player.Instance.maxJumpSpeed = 6.5f;
		GorillaLocomotion.Player.Instance.jumpMultiplier = 1.1f;
	}
}