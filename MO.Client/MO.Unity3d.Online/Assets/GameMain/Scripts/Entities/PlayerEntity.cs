﻿using MO.Unity3d.Data;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityGameFramework.Runtime;

namespace MO.Unity3d.Entities
{
	public class PlayerEntity : EntityLogic
	{
		public string horizontalAxis = "Horizontal";
		public string verticalAxis = "Vertical";

		private float inputHorizontal;
		private float inputVertical;
		private PlayerData _playerData;

		protected internal override void OnInit(object userData)
		{
			base.OnInit(userData);
			GetComponent<Renderer>().material.color = Color.gray;
			_playerData = (PlayerData)userData;
			transform.position = new Vector3(_playerData.X, _playerData.Y, _playerData.Z);

			Vector3 dir = new Vector3(
				_playerData.RX,
				_playerData.RY,
				_playerData.RZ);
			Quaternion quaternion = Quaternion.LookRotation(dir);
			this.transform.rotation = quaternion;
		}

		protected internal override void OnUpdate(float elapseSeconds, float realElapseSeconds)
		{
			Vector3 destDirection = new Vector3(_playerData.RX, _playerData.RY, _playerData.RZ);
			if (Vector3.Distance(transform.eulerAngles, destDirection) > 0.0004f)
			{
				transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(destDirection), 8f * Time.deltaTime);
			}

			float dist = 0.0f;
			float deltaSpeed = (2.0f * Time.deltaTime);

			Vector3 destPosition = new Vector3(_playerData.X, _playerData.Y, _playerData.Z);
			dist = Vector3.Distance(new Vector3(destPosition.x, destPosition.y, destPosition.z),
				new Vector3(transform.position.x, transform.position.y, transform.position.z));

			if (dist > 0.01f)
			{
				Vector3 pos = transform.position;

				Vector3 movement = destPosition - pos;
				movement.y = 0f;
				movement.Normalize();

				movement *= deltaSpeed;

				if (dist > deltaSpeed || movement.magnitude > deltaSpeed)
					pos += movement;
				else
					pos = destPosition;

				transform.position = pos;
			}

			base.OnUpdate(elapseSeconds, realElapseSeconds);
		}


        IEnumerator MoveToPosition()
        {
            while (transform.localPosition != new Vector3(_playerData.X, _playerData.Y, _playerData.Z))
            {
				transform.localPosition = Vector3.MoveTowards(transform.localPosition, new Vector3(_playerData.X, _playerData.Y, _playerData.Z), 2.0f * Time.deltaTime);
                yield return 0;
            }
        }
    }
}