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
			set { 
				_wigth = value;
				maxStack = _wigth * _higher;
			}
		}

		[SerializeField] private int _higher = 13;
		/// <summary>
		///�@�C���x���g���̍���
		/// </summary>
		public int higher {
			get { return _higher; }
			set { 
				_higher = value;
				maxStack = _higher * _wigth;
			}
		}

		public int maxStack = 0;

		public List<ItemEntry> items = new List<ItemEntry>();

		public void AddNewItem (ItemData item,int Amount) {
			if (items.Count >= wigth * higher) {
				
			}
			else {
				items.Add (new ItemEntry(item,Amount));
			}
		}
	}

}