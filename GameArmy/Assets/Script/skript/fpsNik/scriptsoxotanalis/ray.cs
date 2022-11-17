﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ray : MonoBehaviour
{
	public bool flag;
	public Camera _fpcCamera;
	private Ray _ray;
	private RaycastHit _hit;

	[SerializeField] private float _maxDistanceRay;

	private void Update()
	{
		Ray();
		DrawRay();
	}
	private void Ray()
	{
		_ray = _fpcCamera.ScreenPointToRay(new Vector2(Screen.width / 2, Screen.height / 2));
	}

	private void DrawRay()
	{
		if (Physics.Raycast(_ray, out _hit, _maxDistanceRay))
		{
			Debug.DrawRay(_ray.origin, _ray.direction * _maxDistanceRay, Color.blue);
			flag = true;
		}

		if (_hit.transform == null)
		{
			Debug.DrawRay(_ray.origin, _ray.direction * _maxDistanceRay, Color.red);
			flag = false;
		}
	}
}
