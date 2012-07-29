using UnityEngine;
using System.Collections;

namespace PAG.Accessor {
	public interface IDataAccessor {
		Object GetValue(string key);
		void SetValue(Object val, string key);
	}
}
