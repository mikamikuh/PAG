using UnityEngine;
using UnityEditor;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using PAG.Utility;
using TemplateEngine;

namespace PAG.Generator {
	public class DataAccessorGenerator : CodeGenerator {
		
		string ns;
		string className;
		string scriptName;
		string prefabPath;
		IDictionary<string, string> variables;
		
		public DataAccessorGenerator(string ns, string className, string scriptName, string prefabPath, IDictionary<string, string> variables) {
			this.ns = ns;
			this.className = className;
			this.scriptName = scriptName;
			this.prefabPath = prefabPath;
			this.variables = variables;
		}
		
		public override void execute() {
			Template target = new Template(AssetPathUtility.DataAccessorTemplatePath, false);
			target.Set("className", className);
			target.Set("scriptName", scriptName);
			target.Set("namespace", ns);
			target.Set("prefabPath", prefabPath);
			target.Set("getCases", CreateGetCases());
			target.Set("setCases", CreateSetCases());
			
			string folderPath = AssetPathUtility.DataAccessorGeneratePath;
			string generatePath = NamingRuleUtility.CreateDataAccessorGeneratePath(className);
			GenerateCode(folderPath, generatePath, target.ToString());
		}
		
		private string CreateGetCases() {
			StringBuilder generateCode = new StringBuilder();
			
			foreach(KeyValuePair<string, string> pair in variables) {
				generateCode.Append("				case \"" + pair.Key + "\": return data." + pair.Key + ";" + System.Environment.NewLine);
			}		
			return generateCode.ToString();
		}
	
		private string CreateSetCases() {
			StringBuilder generateCode = new StringBuilder();
			
			foreach(KeyValuePair<string, string> pair in variables) {
				generateCode.Append("				case \"" + pair.Key + "\": data." + pair.Key + " = (" + pair.Value + ")val; break;" + System.Environment.NewLine);
			}
			return generateCode.ToString();
		}
	}
}