using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace PAG.Accessor {
	public interface IAccessorManager {
		IDataAccessor GetDataAccessor(GameObject prefab);
		Object Get(string key);
		Dictionary<string, IDataAccessor> GetAll();
	}
}