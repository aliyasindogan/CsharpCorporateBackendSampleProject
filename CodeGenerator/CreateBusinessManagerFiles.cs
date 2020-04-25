using System;
using System.IO;

namespace CodeGenerator
{
    public class CreateBusinessManagerFiles : GeneratorBase
    {
        protected override void GenerateClassFiles(string path)
        {
            foreach (var type in Types)
            {
                var content = GenerateClassFilesType(type);
                if (!type.FullName.Contains("ComplexType"))
                    File.WriteAllText(path + type.Name + "Manager.cs", content, System.Text.Encoding.UTF8);
            }
        }

        private string GenerateClassFilesType(Type type)
        {
            var projectName = Form1.frm.txtProjectName.Text;

            return fmtClassFile
                .Replace("[ClassName]", type.Name)
                .Replace("[ProjectName]", projectName)
                .Replace("[ClassToTitleCase]", type.Name.Substring(0, 1).ToLower() + type.Name.Substring(1, type.Name.Length - 1));
        }

        private const string fmtClassFile = @"
using Moonwell.Core.CrossCuttingConcers.Validation.FluentValidation;
using [ProjectName].Business.Abstract;
using [ProjectName].Business.ValidationRules.FluentValidation;
using [ProjectName].DataAccess.Abstract;
using [ProjectName].Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Linq;

namespace [ProjectName].Business.Concrete.Managers
{
    public class [ClassName]Manager : I[ClassName]Service
    {
        private I[ClassName]Dal _[ClassToTitleCase]Dal;

        public [ClassName]Manager(I[ClassName]Dal [ClassToTitleCase]Dal)
        {
            _[ClassToTitleCase]Dal = [ClassToTitleCase]Dal;
        }

       public [ClassName] Add([ClassName] entity)
        {
            ValidatorTool.FluentValidate(new [ClassName]Validator(), entity);
            return _[ClassToTitleCase]Dal.Add(entity);
        }

        public bool Any(Expression<Func<[ClassName], bool>> filter)
        {
             return _[ClassToTitleCase]Dal.Any(filter);
        }

        public void Delete([ClassName] entity)
        {
            ValidatorTool.FluentValidate(new [ClassName]Validator(), entity);
            _[ClassToTitleCase]Dal.Delete(entity);
        }

        public [ClassName] Get(Expression<Func<[ClassName], bool>> filter)
        {
            return _[ClassToTitleCase]Dal.Get(filter);
        }

        public List<[ClassName]> GetList(Expression<Func<[ClassName], bool>> filter = null)
        {
         return _[ClassToTitleCase]Dal.Get(filter);
        }

        public [ClassName] Update([ClassName] entity)
        {
            ValidatorTool.FluentValidate(new [ClassName]Validator(), entity);
            return _[ClassToTitleCase]Dal.Update(entity);
        }
    }
}
";
    }
}