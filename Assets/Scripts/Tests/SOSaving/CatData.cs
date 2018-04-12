using System;
using UnityEngine;

namespace Tests.SOSaving
{
	[Serializable]
	public class CatData
	{
		[SerializeField] private string _name;
		[SerializeField] private string _trait;
		[SerializeField] private int _maxCatHealth;

		public string Trait
		{
			get { return _trait; }
			set { _trait = value; }
		}

		public int MaxCatHealth
		{
			get { return _maxCatHealth; }
			set { _maxCatHealth = value; }
		}

		public string Name
		{
			get { return _name; }
			set { _name = value; }
		}
	}
}
