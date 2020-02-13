﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AITurret : MonoBehaviour
{
	public Transform target;
	public GameObject turret;
	public Rigidbody m_Shell;                   // Prefab of the shell.
	public Transform m_FireTransform;           // A child of the tank where the shells are spawned.
	public Slider m_AimSlider;                  // A child of the tank that displays the current launch force.
	public AudioSource m_ShootingAudio;         // Reference to the audio source used to play the shooting audio. NB: different to the movement audio source.
	public AudioClip m_ChargingClip;            // Audio that plays when each shot is charging up.
	public AudioClip m_FireClip;                // Audio that plays when each shot is fired.
	public float m_MinLaunchForce = 20f;        // The force given to the shell if the fire button is not held.
	public float m_MaxLaunchForce = 100f;       // The force given to the shell if the fire button is held for the max charge time.
	public float m_MaxChargeTime = 3f;			// How long the shell can charge for before it is fired at max force.


	private string m_FireButton;                // The input axis that is used for launching shells.
	private float m_CurrentLaunchForce;         // The force that will be given to the shell when the fire button is released.
	private float m_ChargeSpeed;                // How fast the launch force increases, based on the max charge time.
	private bool m_Fired;                 // Whether or not the shell has been launched with this button press.

	public float maximumLookDistance = 300f;
	public float maximumAttackDistance = 150f;
	public float minimumDistanceFromPlayer = 30f;
	public float rotationDamping = 2f;

	private void OnEnable()
	{
		// When the tank is turned on, reset the launch force and the UI
		m_CurrentLaunchForce = m_MinLaunchForce;
		m_AimSlider.value = m_MinLaunchForce;
	}

	private void Start()
	{
		// The rate that the launch force charges up is the range of possible forces by the max charge time.
		m_ChargeSpeed = (m_MaxLaunchForce - m_MinLaunchForce) / m_MaxChargeTime;
	}

	public void Update()
	{
		// The slider should have a default value of the minimum launch force.
		m_AimSlider.value = m_MinLaunchForce;

		var distance = Vector3.Distance(target.position, transform.position);

		if (distance <= maximumLookDistance)
		{
			LookAtTarget();
		}

		// Otherwise, if the fire button has just started being pressed...
		while (distance <= maximumAttackDistance)
		{
			InvokeRepeating("Charge", 0.2f , m_MaxChargeTime);

		}
	}


	public void LookAtTarget()
	{
		var dir = target.position - transform.position;
		dir.y = 0;
		var rotation = Quaternion.LookRotation(dir);
		turret.transform.rotation = Quaternion.Slerp(transform.rotation, rotation, Time.deltaTime * rotationDamping);
	}


	public void Shoot()
	{
		// Create an instance of the shell and store a reference to it's rigidbody.
		Rigidbody shellInstance =
			Instantiate(m_Shell, m_FireTransform.position, m_FireTransform.rotation) as Rigidbody;

		// Set the shell's velocity to the launch force in the fire position's forward direction.
		shellInstance.velocity = m_CurrentLaunchForce * m_FireTransform.forward;

		// Change the clip to the firing clip and play it.
		m_ShootingAudio.clip = m_FireClip;
		m_ShootingAudio.Play();

		// Reset the launch force.  This is a precaution in case of missing button events.
		m_CurrentLaunchForce = m_MinLaunchForce;
	}

	public void Charge()
	{
		// ... reset the fired flag and reset the launch force.
		m_CurrentLaunchForce = m_MinLaunchForce;
		float counter = 0;

		//StartCoroutine(ChargeSound());

		while (counter <= m_MaxChargeTime)
		{
			m_CurrentLaunchForce += m_ChargeSpeed * Time.deltaTime;
			counter += Time.deltaTime;
		}
		
		// If the max force has been exceeded and the shell hasn't yet been launched...
		if (m_CurrentLaunchForce >= m_MaxLaunchForce || counter == m_MaxChargeTime)
		{
			// ... use the max force and launch the shell.
			m_CurrentLaunchForce = m_MaxLaunchForce;
			Shoot();
		}

	}

	IEnumerator ChargeSound()
	{
		// Change the clip to the charging clip and start it playing.
		m_ShootingAudio.clip = m_ChargingClip;
		m_ShootingAudio.Play();
		yield return new WaitForSeconds(m_MaxChargeTime);
		m_ShootingAudio.Stop();
	}
}
