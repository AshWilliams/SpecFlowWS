﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.4.0.0
//      SpecFlow Generator Version:2.4.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace FunkyBDD.SxS.Framework.Specs
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.4.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [Xunit.TraitAttribute("Category", "Styleguide")]
    public partial class TheBaseFrameworkWorksWellFeature : Xunit.IClassFixture<TheBaseFrameworkWorksWellFeature.FixtureData>, System.IDisposable
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
        private Xunit.Abstractions.ITestOutputHelper _testOutputHelper;
        
#line 1 "FrameworkTests.feature"
#line hidden
        
        public TheBaseFrameworkWorksWellFeature(TheBaseFrameworkWorksWellFeature.FixtureData fixtureData, Xunit.Abstractions.ITestOutputHelper testOutputHelper)
        {
            this._testOutputHelper = testOutputHelper;
            this.TestInitialize();
        }
        
        public static void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "The base framework works well", "\tIn order to \r\n\t\trun automated tests\r\n\tAs a \r\n\t\ttester\r\n\tI want to \r\n\t\thave a wor" +
                    "king base framework", ProgrammingLanguage.CSharp, new string[] {
                        "Styleguide"});
            testRunner.OnFeatureStart(featureInfo);
        }
        
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public virtual void TestInitialize()
        {
        }
        
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<Xunit.Abstractions.ITestOutputHelper>(_testOutputHelper);
        }
        
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        public virtual void FeatureBackground()
        {
#line 10
#line 11
 testRunner.Given("I open the test page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
        }
        
        void System.IDisposable.Dispose()
        {
            this.ScenarioTearDown();
        }
        
        [Xunit.FactAttribute(DisplayName="All packages correctly installed | Check the helpers")]
        [Xunit.TraitAttribute("FeatureTitle", "The base framework works well")]
        [Xunit.TraitAttribute("Description", "All packages correctly installed | Check the helpers")]
        public virtual void AllPackagesCorrectlyInstalledCheckTheHelpers()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("All packages correctly installed | Check the helpers", null, ((string[])(null)));
#line 13
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 10
this.FeatureBackground();
#line 14
 testRunner.Given("I change the language to \'DE\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 15
 testRunner.When("I confirm the disclaimer", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 16
 testRunner.Then("The homepage has the title \'Private | Swiss Life\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 17
  testRunner.And("The page has the color 255, 53, 53, 53", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.TheoryAttribute(DisplayName="Check the titel translation")]
        [Xunit.TraitAttribute("FeatureTitle", "The base framework works well")]
        [Xunit.TraitAttribute("Description", "Check the titel translation")]
        [Xunit.InlineDataAttribute("DE", "Die passende Vorsorge für jede Lebensphase", "Vorsorge für Familien", "Berufliche Vorsorge", new string[0])]
        [Xunit.InlineDataAttribute("EN", "The right provision for each stage of life", "Future provisions for families", "Occupational provisions", new string[0])]
        [Xunit.InlineDataAttribute("FR", "La prévoyance adaptée à chaque phase de la vie", "La prévoyance pour les familles", "Prévoyance professionnelle", new string[0])]
        [Xunit.InlineDataAttribute("IT", "La previdenza giusta per ogni fase della vita", "Previdenza per la famiglia", "Previdenza professionale", new string[0])]
        public virtual void CheckTheTitelTranslation(string lang, string title, string familyTeaserTitle, string occupationalTeaserTitle, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Check the titel translation", null, exampleTags);
#line 19
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 10
this.FeatureBackground();
#line 20
 testRunner.When(string.Format("I change the language to \'{0}\'", lang), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 21
 testRunner.Then(string.Format("The banner title should be \'{0}\'", title), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 22
  testRunner.And(string.Format("The family teaser title schould be \'{0}\'", familyTeaserTitle), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 23
  testRunner.And(string.Format("The occupational teaser title schould be \'{0}\'", occupationalTeaserTitle), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="Check mouse over button")]
        [Xunit.TraitAttribute("FeatureTitle", "The base framework works well")]
        [Xunit.TraitAttribute("Description", "Check mouse over button")]
        public virtual void CheckMouseOverButton()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Check mouse over button", null, ((string[])(null)));
#line 31
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 10
this.FeatureBackground();
#line 32
 testRunner.When("I mover over the family teaser", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 33
 testRunner.Then("The button should be shown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="Page 404 works")]
        [Xunit.TraitAttribute("FeatureTitle", "The base framework works well")]
        [Xunit.TraitAttribute("Description", "Page 404 works")]
        public virtual void Page404Works()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Page 404 works", null, ((string[])(null)));
#line 35
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 10
this.FeatureBackground();
#line 36
 testRunner.When("I call a page not exists", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 37
 testRunner.Then("The homepage has the title \'404 | Swiss Life\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="Validate FunkyBDD.SxS.Helpers table comparer")]
        [Xunit.TraitAttribute("FeatureTitle", "The base framework works well")]
        [Xunit.TraitAttribute("Description", "Validate FunkyBDD.SxS.Helpers table comparer")]
        public virtual void ValidateFunkyBDD_SxS_HelpersTableComparer()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Validate FunkyBDD.SxS.Helpers table comparer", null, ((string[])(null)));
#line 39
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 10
this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "Col1",
                        "Col2",
                        "Col3"});
            table1.AddRow(new string[] {
                        "Value 1",
                        "Value 2",
                        "Value 3"});
#line 40
 testRunner.Then("the TableComparer should work right", ((string)(null)), table1, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.4.0.0")]
        [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
        public class FixtureData : System.IDisposable
        {
            
            public FixtureData()
            {
                TheBaseFrameworkWorksWellFeature.FeatureSetup();
            }
            
            void System.IDisposable.Dispose()
            {
                TheBaseFrameworkWorksWellFeature.FeatureTearDown();
            }
        }
    }
}
#pragma warning restore
#endregion

