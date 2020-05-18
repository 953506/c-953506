using System;
using System.Collections.Generic;
using System.Text;

namespace lr6
{
    interface IUniversityPerson
    {
        string Name { get; }
        string SurName { get;  }
        string University { get; set; }
        int Age { get;}
        public string ImportantInformation { get; set; }

        void WriteCommonInformation();
        void EnterImportantInformation();
        void WriteImportantInformation();
    }
}
