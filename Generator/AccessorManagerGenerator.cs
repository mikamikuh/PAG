using UnityEngine;
using UnityEditor;
using System.Collections;
using System.Collections.Generic;
using TemplateEngine;
using PAG.Utility;

namespace PAG.Generator {
	public class AccessorManagerGenerator : CodeGenerator {
		
		private string ns;
		private string className;
		private IList<string> dataClassNames;
		
		public AccessorManagerGenerator(string ns, string className, IList<string> dataClassNames) {
			this.ns = ns;
			this.className = className;
			this.dataClassNames = dataClassNames;
		}
		
		public override void execute() {
			Template target = new Template(AssetPathUtility.AccessorManagerTemplatePath, false);
			target.Set("className", className);
			target.Set("namespace", ns);
			
			string createCode = "";
			
			foreach(string name in dataClassNames) {
				createCode += "			obj = prefab.GetComponent<" + name + ">();";
				createCode += System.Environment.NewLine;
				createCode += "			if(obj != null) return new " + name + "DataAccessor(obj);";
				createCode += System.Environment.NewLine;
			}
			
			target.Set("createCode", createCode);
			
			string folderPath = AssetPathUtility.AccessorManagerGeneratePath;
			string generatePath = NamingRuleUtility.CreateAccessorManagerGeneratePath(className);
			GenerateCode(folderPath, generatePath, target.ToString());
		}
	}
}
