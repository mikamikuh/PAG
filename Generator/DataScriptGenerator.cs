using UnityEngine;
using UnityEditor;
using System.Collections;
using System.Collections.Generic;
using PAG.Utility;
using TemplateEngine;

namespace PAG.Generator {
	public class DataScriptGenerator : CodeGenerator {
		
		private string className;
		private IDictionary<string, string> variables;
		
		public DataScriptGenerator(string className, IDictionary<string, string> variables) {
			this.className = className;
			this.variables = variables;
		}
		
		public override void execute() {
			Template target = new Template(AssetPathUtility.DataScriptTemplatePath, false);
			target.Set("className", className);
			
			string variableCode = "";
			
			foreach(KeyValuePair<string, string> pair in variables) {
				string line = "	public " + pair.Value + " " + pair.Key + ";";
				variableCode += line + System.Environment.NewLine;
			}
			
			target.Set("variables", variableCode);
			
			string folderPath = AssetPathUtility.DataScriptGeneratePath;
			string generatePath = NamingRuleUtility.CreateDataScriptGeneratePath(className);
			GenerateCode(folderPath, generatePath, target.ToString());
		}
	}
}