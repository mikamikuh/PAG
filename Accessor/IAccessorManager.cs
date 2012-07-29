using UnityEngine;
using System.Collections;

namespace UnityTableViewer.Accessor {
	public interface IAccessorManager {
		Object Get(string key);
	}
}