﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.7.1.0
//      SpecFlow Generator Version:1.7.0.0
//      Runtime Version:4.0.30319.225
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
namespace TechTalk.SpecFlow.Specs.Features
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.7.1.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Specifying the culture to be used for argument conversions")]
    public partial class SpecifyingTheCultureToBeUsedForArgumentConversionsFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "BindingCulture.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Specifying the culture to be used for argument conversions", "", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.TestFixtureTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("The default culture is used for bindings if not specified")]
        public virtual void TheDefaultCultureIsUsedForBindingsIfNotSpecified()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("The default culture is used for bindings if not specified", ((string[])(null)));
#line 3
this.ScenarioSetup(scenarioInfo);
#line hidden
#line 4
 testRunner.Given("a scenario \'Simple Scenario\' as", "Given I have entered 3.14 into the calculator", ((TechTalk.SpecFlow.Table)(null)));
#line hidden
#line 8
 testRunner.And("the following step definition", "[Given(@\"I have entered (.+) into the calculator\")]\r\npublic void GivenIHaveEntere" +
                    "d(double number)\r\n{\r\nif (number != 3.14) throw new Exception(\"number converted i" +
                    "ncorrectly\");\r\n}", ((TechTalk.SpecFlow.Table)(null)));
#line 16
 testRunner.When("I execute the tests");
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "Succeeded"});
            table1.AddRow(new string[] {
                        "1"});
#line 17
 testRunner.Then("the execution summary should contain", ((string)(null)), table1);
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("The scenario language is used for bindings if not specified")]
        public virtual void TheScenarioLanguageIsUsedForBindingsIfNotSpecified()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("The scenario language is used for bindings if not specified", ((string[])(null)));
#line 21
this.ScenarioSetup(scenarioInfo);
#line hidden
#line 22
 testRunner.Given("there is a feature file in the project as", "#language:de\r\nFunktionalität: Argument transformation\r\n\r\nSzenario: Steps mit Argu" +
                    "menten\r\nAngenommen ich habe 3,14 in den Taschenrechner eingegeben", ((TechTalk.SpecFlow.Table)(null)));
#line hidden
#line 30
 testRunner.And("the following step definition", "[Given(@\"ich habe (.+) in den Taschenrechner eingegeben\")]\r\npublic void GivenIHav" +
                    "eEntered(double number)\r\n{\r\nif (number != 3.14) throw new Exception(\"number conv" +
                    "erted incorrectly\");\r\n}", ((TechTalk.SpecFlow.Table)(null)));
#line 38
 testRunner.When("I execute the tests");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "Succeeded"});
            table2.AddRow(new string[] {
                        "1"});
#line 39
 testRunner.Then("the execution summary should contain", ((string)(null)), table2);
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("The binding culture can be specified to be different than the scenario culture")]
        [NUnit.Framework.CategoryAttribute("config")]
        public virtual void TheBindingCultureCanBeSpecifiedToBeDifferentThanTheScenarioCulture()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("The binding culture can be specified to be different than the scenario culture", new string[] {
                        "config"});
#line 44
this.ScenarioSetup(scenarioInfo);
#line hidden
#line 45
 testRunner.Given("a scenario \'Simple Scenario\' as", "Given I have entered 3,14 into the calculator", ((TechTalk.SpecFlow.Table)(null)));
#line hidden
#line 49
 testRunner.And("the following step definition", "[Given(@\"I have entered (.+) into the calculator\")]\r\npublic void GivenIHaveEntere" +
                    "d(double number)\r\n{\r\nif (number != 3.14) throw new Exception(\"number converted i" +
                    "ncorrectly\");\r\n}", ((TechTalk.SpecFlow.Table)(null)));
#line hidden
#line 57
 testRunner.And("the specflow configuration is", "<specFlow>\r\n<bindingCulture name=\"de-DE\" />\r\n</specFlow>", ((TechTalk.SpecFlow.Table)(null)));
#line 63
 testRunner.When("I execute the tests");
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "Succeeded"});
            table3.AddRow(new string[] {
                        "1"});
#line 64
 testRunner.Then("the execution summary should contain", ((string)(null)), table3);
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#endregion
