using System;
using System.IO;

namespace CodeGenerator
{
    public class CreateDataAccessEfConcreteFiles : GeneratorBase
    {
        protected override void GenerateClassFiles(string path)
        {
            foreach (var type in Types)
            {
                var content = GenerateClassFilesType(type);
                if (!type.FullName.Contains("ComplexType"))
                    File.WriteAllText(path + "Ef" + type.Name + "Dal.cs", content, System.Text.Encoding.UTF8);
            }
        }

        private string GenerateClassFilesType(Type type)
        {
            var context = Form1.frm.txtContextName.Text;
            var projectName = Form1.frm.txtProjectName.Text;
            return fmtClassFile
                    .Replace("[ClassName]", type.Name)
                    .Replace("[ContextName]", context)
                    .Replace("[ProjectName]", projectName);
        }

        private const string fmtClassFile = @"using NewGenFramework.Core.DataAccess.EntityFramework;
using [ProjectName].DataAccess.Abstract;
using [ProjectName].DataAccess.Concrete.Context;
using [ProjectName].Entities.Concrete;

namespace [ProjectName].DataAccess.Concrete.EntityFramework
{
		 public class Ef[ClassName]Dal:EfRepository<[ClassName],[ContextName]>,I[ClassName]Dal
		{
		}
}
";
    }
}