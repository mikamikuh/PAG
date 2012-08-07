using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace PAG.Accessor {
	public abstract class AccessorManagerBase : IAccessorManager {
		protected Dictionary<string, IDataAccessor> prefabs;
		
		public AccessorManagerBase() {
			prefabs = new Dictionary<string, IDataAccessor>();
		}
		
		public virtual IDataAccessor GetDataAccessor(GameObject prefab) {
			return null;
		}
		
		public virtual Object Get(string key) {
			return null;
		}
		
		public Dictionary<string, IDataAccessor> GetAll() {
			return prefabs;
		}
	}
}
