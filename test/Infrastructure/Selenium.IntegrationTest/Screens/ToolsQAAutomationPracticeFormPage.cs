﻿using Optivem.Core.Common.WebAutomation;
using Optivem.Test.Common.WebAutomation;

namespace Optivem.Infrastructure.Selenium.IntegrationTest.Pages
{
    public class ToolsQAAutomationPracticeFormPage : TestScreen
    {
        public ToolsQAAutomationPracticeFormPage(TestDriver driver) 
            : base(driver)
        {
        }

        public TestTextBox FirstName => Driver.FindTextBox(FindType.Name, "firstname");

        public TestTextBox LastName => Driver.FindTextBox(FindType.Name, "lastname");

        public TestRadioGroup Gender => Driver.FindRadioGroup(FindType.Name, "sex");

        public TestRadioGroup YearsOfExperience => Driver.FindRadioGroup(FindType.Name, "exp");

        public TestCheckBoxGroup Profession => Driver.FindCheckBoxGroup(FindType.Name, "profession");

        public TestCheckBoxGroup AutomationTool => Driver.FindCheckBoxGroup(FindType.Name, "tool");

        public TestComboBox Continent => Driver.FindComboBox(FindType.Name, "continents");

        // TODO: VC: Radio group with names: https://www.toolsqa.com/selenium-webdriver/checkbox-radio-button-operations/
    }

}