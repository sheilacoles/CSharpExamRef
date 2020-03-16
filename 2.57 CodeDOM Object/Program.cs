using System;
using System.CodeDom;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._57_CodeDOM_Object
{
    class Program
    {
        static void Main(string[] args)
        {
            CodeCompileUnit compileUnit = new CodeCompileUnit();

            CodeNamespace personnelNameSpace = new CodeNamespace("Personnel");

            personnelNameSpace.Imports.Add(new CodeNamespaceImport("System"));

            CodeTypeDeclaration personClass = new CodeTypeDeclaration("Person");
            personClass.IsClass = true;
            personClass.TypeAttributes = System.Reflection.TypeAttributes.Public;

            personnelNameSpace.Types.Add(personClass);

            CodeMemberField nameField = new CodeMemberField("String", "name");
            nameField.Attributes = MemberAttributes.Private;

            personClass.Members.Add(nameField);

            compileUnit.Namespaces.Add(personnelNameSpace);

            //Now to send our document somewhere, create a provider to parse the document
            CodeDomProvider provider = CodeDomProvider.CreateProvider("CSharp");
            StringWriter s = new StringWriter();
            CodeGeneratorOptions options = new CodeGeneratorOptions();

            provider.GenerateCodeFromCompileUnit(compileUnit, s, options);
            s.Close();

            Console.WriteLine(s.ToString());
            Console.ReadKey();
        }
    }
}
