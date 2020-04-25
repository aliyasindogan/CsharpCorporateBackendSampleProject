﻿using System;
using System.IO;
using System.Text;

namespace CodeGenerator
{
    public class CreateBusinessFluentValidationValidationRulesGenerator : GeneratorBase
    {
        protected override void GenerateClassFiles(string path)
        {
            foreach (var type in Types)
            {
                var content = GenerateClassFilesType(type);
                if (!type.FullName.Contains("ComplexType"))
                    File.WriteAllText(path + type.Name + "Validator.cs", content, System.Text.Encoding.UTF8);
            }
        }

        private string GenerateClassFilesType(Type type)
        {
            var sb = new StringBuilder();
            // ozellikleri al (Inheritance icin bu calismaz)
            var props = type.GetProperties();

            foreach (var prop in props)
            {
                sb.AppendLine($"RuleFor(x => x.{prop.Name}).NotEmpty();");
            }
            var projectName = Form1.frm.txtProjectName.Text;
            return fmtClassFile
                .Replace("[ClassName]", type.Name)
                .Replace("[ClassToTitleCase]", type.Name.Substring(0, 1).ToLower() + type.Name.Substring(1, type.Name.Length - 1))
                .Replace("[ProjectName]", projectName)
                .Replace("[Body]", sb.ToString());
        }

        private const string fmtClassFile = @"using FluentValidation;
using [ProjectName].Entities.Concrete;
using [ProjectName].Business.DependencyResolvers.Ninject;
using [ProjectName].Entities.Concrete;
using [ProjectName].Business.Abstract;

namespace [ProjectName].Business.ValidationRules.FluentValidation
{
   public class [ClassName]Validator:AbstractValidator<[ClassName]>
    {
        public [ClassName]Validator()
        {
        //Eğer CustomRule yazmak istenirse service interfacelerini çözer custom rule için gerekli metodlara ulaşmanızı sağlar
        var [ClassToTitleCase]Service = DependencyResolver<I[ClassName]Service>.Resolve();
        //Sadece Boş Olamaz Kontrolü Yapar
            [Body]

        //Custom Rule Kullanımı Aşağıdaki gibidir
         //Custom(rm =>
            //{
            //var useremail = userService.UniqueEmail(rm.Email);
            //    if (rm.Agreement != true /*&& useremail.Email != null*/)
            //    {
            //        return new ValidationFailure(/*you must type the property name here, you must type the error message here */);
        //    }
        //    return null;
        //});
        }
}
}";
    }
}