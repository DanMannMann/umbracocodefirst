using Marsman.UmbracoCodeFirst.DataTypes;
using System;

namespace Marsman.UmbracoCodeFirst.Attributes
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
    public class PreValueFileAttribute : PreValueFactoryAttribute
    {
        private string _relativePath;

        public PreValueFileAttribute(string relativePath)
            : base(typeof(FilePreValueFactory))
        {
            _relativePath = relativePath;
        }

        public override IPreValueFactory GetFactory()
        {
            return new FilePreValueFactory(_relativePath);
        }
    }
}