using UnityEngine;
using System;
using System.Collections.Generic;
using Test.Item;

namespace Test.Character.Inventory {
	/// <summary>
	/// �C���x���g���̊��N���X
	/// </summary>
	public abstract class A_Inventory : MonoBehaviour {

		[SerializeField] private int _wigth = 10;
		/// <summary>
		/// �C���x���g���̉���
		/// </summary>
		public int wigth {
			get { return _wigth; }
			set { _wigth = value; }
		}

		[SerializeField] private int _higher = 13;
		/// <summary>
		///�@�C���x���g���̍���
		/// </summary>
		public int higher {
			get { return _higher; }
			set { _higher = value; }
		}

		/// <summary>
		/// �C���x���g���Ɋi�[���Ă���A�C�e���̃��X�g
		/// </summary>
		[SerializeField] public List<ItemEntry> items = new List<ItemEntry>();
	}

}