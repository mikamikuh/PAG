using UnityEngine;
using System.Collections;

namespace UnityTableViewer.Accessor {
	public interface IDataAccessor {
		Object GetValue(string key);
		void SetValue(Object val, string key);
	}
}
