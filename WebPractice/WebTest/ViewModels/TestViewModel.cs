using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebTest.ViewModels
{
    public class TestViewModel
    {
        public List<TestViewModel> test_list { get; set; }

        public string A { get; set; }
        public string B { get; set; }
        public string C { get; set; }
    }
}