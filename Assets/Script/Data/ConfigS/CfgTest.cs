using System;
using System.Collections.Generic;
using UnityEngine;

namespace Config.ScriptableConfig
{
	[Serializable]
	public class CfgTest: ConfigSoBase
	{
		public string B;
		public List<int> C;
		public List<int> E;
	}
}
