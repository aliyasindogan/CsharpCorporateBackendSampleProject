using System;
using System.IO;

namespace CodeGenerator
{
    public class CreateBusinessAbstractFiles : GeneratorBase
    {
        protected override void GenerateClassFiles(string path)
        {
            foreach (var type in Types)
            {
                var content = GenerateClassFilesType(type);
                if (!type.FullName.Contains("ComplexType"))
                    File.WriteAllText(path + "I" + type.Name + "Service.cs", content, System.Text.Encoding.UTF8);
            }
        }

        private string GenerateClassFilesType(Type type)
        {
            var projectName = Form1.frm.txtProjectName.Text;

            return fmtClassFile
                    .Replace("[ClassName]", type.Name)
                    .Replace("[ClassToTitleCase]", type.Name.Substring(0, 1).ToLower() + type.Name.Substring(1, type.Name.Length - 1))
                    .Replace("[ProjectName]", projectName);
        }

        private const string fmtClassFile = @"
using System.Collections.Generic;
using [ProjectName].Entities.ComplexTypes;
using [ProjectName].Entities.Concrete;

namespace [ProjectName].Business.Abstract
{
		public interface I[ClassName]Service
		{
		 [ClassName] Add([ClassName] entity);

        [ClassName] Update([ClassName] entity);

        void Delete([ClassName] entity);

        bool Any(Expression<Func<[ClassName], bool>> filter);

        List<[ClassName]> GetList(Expression<Func<[ClassName], bool>> filter = null);

        [ClassName] Get(Expression<Func<[ClassName], bool>> filter);
		}
}";
    }
}