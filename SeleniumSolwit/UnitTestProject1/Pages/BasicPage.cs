﻿using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject1.Pages
{
    class BasicPage
    {
        public IWebDriver Driver{get;}

        public BasicPage(IWebDriver driver)
        {
            Driver = driver;
        }
    }
}