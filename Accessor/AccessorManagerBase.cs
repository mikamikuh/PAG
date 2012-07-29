using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace UnityTableViewer.Accessor {
	public abstract class AccessorManagerBase : IAccessorManager {
		protected Dictionary<string, IDataAccessor> prefabs;
		
		public AccessorManagerBase() {
			prefabs = new Dictionary<string, IDataAccessor>();
		}
		
		public virtual Object Get(string key) {
			return null;
		}
	}
}
