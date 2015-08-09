﻿using Felinesoft.UmbracoCodeFirst.DataTypes;
using Felinesoft.UmbracoCodeFirst.TestTarget.TestFramework;
using Felinesoft.UmbracoCodeFirst.TestTarget.TestModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Umbraco.Core.Models;
using Umbraco.Core.Services;

namespace Felinesoft.UmbracoCodeFirst.TestTarget.Tests
{
    public class DocTypeTests_TypeSet2 : TestBase, ICodeFirstTest
    {
        public void Run()
        {
            Initialise("TypeSet2");
            var types = ContentTypeService.GetAllContentTypes();
            var expectedTypes = GetTypes();
            AssertContentTypes(types, expectedTypes);
        }

        private List<ExpectedType> GetTypes()
        {
            var result = new List<ExpectedType>();
            result.Add(new ExpectedType()
            {
                Alias = "master",
                Name = "Master",
                AllowAtRoot = true,
                AllowedChildrenAliases = new string[] { },
                CompositionAliases = new string[] { },
                Description = string.Empty,
                IconWithColor = "icon-document",
                ListView = false,
                ParentAlias = string.Empty,
                SortOrder = 0
            });
            AddProperties(result.Last(), "master", "Master", 2);
            AddTab(result.Last(), "master", "Master", false, 3);

            result.Add(new ExpectedType()
            {
                Alias = "child1",
                Name = "Child 1",
                AllowAtRoot = false,
                AllowedChildrenAliases = new string[] { },
                CompositionAliases = new string[] { },
                Description = string.Empty,
                IconWithColor = "icon-activity color-green",
                ListView = false,
                ParentAlias = "master",
                SortOrder = 0
            });
            AddProperties(result.Last(), "child1", "Child 1", 4);
            AddTab(result.Last(), "child1", "Child 1", true, 1);

            result.Add(new ExpectedType()
            {
                Alias = "child2",
                Name = "Child 2",
                AllowAtRoot = false,
                AllowedChildrenAliases = new string[] { },
                CompositionAliases = new string[] { },
                Description = string.Empty,
                IconWithColor = "icon-document",
                ListView = false,
                ParentAlias = "master",
                SortOrder = 0
            });
            AddProperties(result.Last(), "child2", "Child 2");
            AddTab(result.Last(), "child2", "Child 2");

            result.Add(new ExpectedType()
            {
                Alias = "grandChild1",
                Name = "Grand Child 1",
                AllowAtRoot = false,
                AllowedChildrenAliases = new string[] { },
                CompositionAliases = new string[] { },
                Description = string.Empty,
                IconWithColor = "icon-document",
                ListView = false,
                ParentAlias = "child1",
                SortOrder = 0
            });
            AddProperties(result.Last(), "grandchild1", "Grandchild 1");
            //grandchild has no tab

            return result;
        }

        private void AddTab(ExpectedType expectedType, string alias, string name, bool useCommon = true, int count = 2)
        {
            expectedType.Tabs = new List<ExpectedTab>();
            expectedType.Tabs.Add(new ExpectedTab()
            {
                Name = name + " Tab",
                SortOrder = 0
            });
            expectedType.Tabs.Last().Properties = new List<ExpectedProperty>();

            if (useCommon)
                expectedType.Tabs.Last().Properties.Add(CommonTabProperty(name));

            count--;
            if (count < 0) return;
            expectedType.Tabs.Last().Properties.Add(new ExpectedProperty()
            {
                Alias = alias + "RichtextEditorTab_" + name.Replace(" ", "_") + "_Tab",
                Name = name + " Richtext Editor Tab",
                Description = "",
                DataType = new ExpectedDataType()
                {
                    DataTypeName = "Richtext editor",
                    DbType = DataTypeDatabaseType.Ntext,
                    PropertyEditorAlias = "Umbraco.TinyMCEv3"
                },
                Mandatory = false,
                SortOrder = 0,
                Regex = ""
            });

            count--;
            if (count < 0) return;
            expectedType.Tabs.Last().Properties.Add(new ExpectedProperty()
            {
                Alias = alias + "DatePickerTab_" + name.Replace(" ", "_") + "_Tab",
                Name = name + " Date Picker Tab",
                Description = "",
                DataType = new ExpectedDataType()
                {
                    DataTypeName = "Date Picker",
                    DbType = DataTypeDatabaseType.Date,
                    PropertyEditorAlias = "Umbraco.Date"
                },
                Mandatory = false,
                SortOrder = 0,
                Regex = ""
            });

            count--;
            if (count < 0) return;
            expectedType.Tabs.Last().Properties.Add(new ExpectedProperty()
            {
                Alias = alias + "TextstringTab_" + name.Replace(" ", "_") + "_Tab",
                Name = name + " Textstring Tab",
                Description = "",
                DataType = new ExpectedDataType()
                {
                    DataTypeName = "Textstring",
                    DbType = DataTypeDatabaseType.Nvarchar,
                    PropertyEditorAlias = "Umbraco.Textbox"
                },
                Mandatory = true,
                SortOrder = 0,
                Regex = ""
            });
        }

        private ExpectedProperty CommonTabProperty(string name)
        {
            return new ExpectedProperty()
            {
                Alias = "commonTabBaseTrueFalse_" + name.Replace(" ", "_") + "_Tab",
                Name = "Common Tab Base True False",
                Description = "",
                DataType = new ExpectedDataType()
                {
                    DataTypeName = "True/false",
                    DbType = DataTypeDatabaseType.Integer,
                    PropertyEditorAlias = "Umbraco.TrueFalse"
                },
                Mandatory = false,
                SortOrder = 0,
                Regex = ""
            };
        }

        private void AddProperties(ExpectedType expectedType, string alias, string name, int count = 3)
        {
            expectedType.Properties = new List<ExpectedProperty>();
            count--;
            if (count < 0) return;
            expectedType.Properties.Add(new ExpectedProperty()
            {
                Name = name + " Textstring Root",
                Alias = alias + "TextstringRoot",
                DataType = new ExpectedDataType()
                {
                    DataTypeName = "Textstring",
                    DbType = DataTypeDatabaseType.Nvarchar,
                    PropertyEditorAlias = "Umbraco.Textbox"
                },
                Description = "",
                Mandatory = false,
                SortOrder = 0,
                Regex = ""
            });
            count--;
            if (count < 0) return;
            expectedType.Properties.Add(new ExpectedProperty()
            {
                Name = name + " True False Root",
                Alias = alias + "TrueFalseRoot",
                DataType = new ExpectedDataType()
                {
                    DataTypeName = "True/false",
                    DbType = DataTypeDatabaseType.Integer,
                    PropertyEditorAlias = "Umbraco.TrueFalse"
                },
                Description = "",
                Mandatory = false,
                SortOrder = 0,
                Regex = ""
            });
            count--;
            if (count < 0) return;
            expectedType.Properties.Add(new ExpectedProperty()
            {
                Name = name + " Numeric Root",
                Alias = alias + "NumericRoot",
                DataType = new ExpectedDataType()
                {
                    DataTypeName = "Numeric",
                    DbType = DataTypeDatabaseType.Integer,
                    PropertyEditorAlias = "Umbraco.Integer"
                },
                Description = "",
                Mandatory = false,
                SortOrder = 0,
                Regex = ""
            });
            count--;
            if (count < 0) return;
            expectedType.Properties.Add(new ExpectedProperty()
            {
                Name = name + " Label Root",
                Alias = alias + "LabelRoot",
                DataType = new ExpectedDataType()
                {
                    DataTypeName = "Label",
                    DbType = DataTypeDatabaseType.Nvarchar,
                    PropertyEditorAlias = "Umbraco.NoEdit"
                },
                Description = "  This be a  lABel ",
                Mandatory = true,
                SortOrder = 0,
                Regex = ""
            });
        }

        protected override IContentTypeBase GetContentType(int id)
        {
            return ContentTypeService.GetContentType(id);
        }
    } 
}