﻿using OpenQA.Selenium.Chrome;
using Optivem.Platform.Test.Infrastructure.Common.WebAutomation.Selenium.Pages;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using Xunit;

namespace Optivem.Platform.Test.Infrastructure.Common.WebAutomation.Selenium
{
    public class SeleniumPageTest
    {
        [Fact]
        public void TestFindTextBoxByName()
        {
            var currentDir = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            using (var driver = new ChromeDriver(currentDir))
            {
                driver.Url = "https://www.toolsqa.com/automation-practice-form/";

                var page = new ToolsQAAutomationPracticeFormPage(driver);

                page.FirstNameTextBox.SetText("John");
                var firstName = page.FirstNameTextBox.GetText();

                // TODO: VC: Check if this should be via textbox?

                Assert.Equal("John", firstName);

                Assert.False(page.SexRadioGroup.HasSelected());

                page.SexRadioGroup.Select(SexType.Male);

                // TODO: VC: Automatic matching between name and enum

                Assert.Equal(SexType.Male, page.SexRadioGroup.GetSelected());

                Assert.False(page.YearsOfExperienceRadioGroup.HasSelected());

                page.YearsOfExperienceRadioGroup.Select(3);

                Assert.Equal(3, page.YearsOfExperienceRadioGroup.GetSelected());

                Assert.False(page.ProfessionCheckBoxGroup.HasSelected());

                page.ProfessionCheckBoxGroup.Select(ProfessionType.AutomationTester);

                Assert.Single(page.ProfessionCheckBoxGroup.GetSelected());

                Assert.Equal(ProfessionType.AutomationTester, page.ProfessionCheckBoxGroup.GetSelected().Single());


            }
        }


    }
}
