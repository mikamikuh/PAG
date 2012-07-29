using UnityEngine;
using System.Collections;

namespace PAG.Accessor {
	public interface IAccessorManager {
		Object Get(string key);
	}
}