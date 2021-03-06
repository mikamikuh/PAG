using UnityEngine;
using System.Collections;

namespace PAG.Utility {
	public class NamingRuleUtility {
		
		public static string CreateAccessorClassName(string prefabName) {
			return prefabName + "DataAccessor";
		}
		
		public static string CreateAccessorManagerGeneratePath(string className) {
			return AssetPathUtility.AccessorManagerGeneratePath + className + "AccessorManager.cs";
		}
		
		public static string CreateDataAccessorGeneratePath(string className) {
			return AssetPathUtility.DataAccessorGeneratePath + className + "DataAccessor.cs";
		}
		
		public static string CreateDataScriptGeneratePath(string className) {
			return AssetPathUtility.DataScriptGeneratePath + className + "Script.cs";
		}
	}
}