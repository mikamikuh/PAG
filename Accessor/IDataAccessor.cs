using System;
using System.Collections;

namespace PAG.Accessor {
	public interface IDataAccessor {
		Object GetValue(string key);
		void SetValue(System.Object val, string key);
	}
}
