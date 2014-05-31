using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Harmonizer.Tests
{
    [TestClass]
    public class ProjectParse
    {
        [TestMethod]
        public void TryProject()
        {
            var item = SlnFileReader.ParseProjectInfo(@"Project(""{FAE04EC0-301F-11D3-BF4B-00C04F79EFBC}"") = ""Лекция 2.3 - Целостность данных и свойства"", ""Lecture23\Лекция 2.3 - Целостность данных и свойства.csproj"", ""{9BFD2B59-C5F6-4C54-BA0C-3FCE63076FF3}""");

            Assert.AreEqual("9BFD2B59-C5F6-4C54-BA0C-3FCE63076FF3", item.Guid);
            Assert.AreEqual("Лекция 2.3 - Целостность данных и свойства", item.FullName);
            
            Assert.AreEqual(true, item.IsProject);
            Assert.AreEqual(@"Lecture23\Лекция 2.3 - Целостность данных и свойства.csproj", item.ProjectFile.ToString());

            Assert.AreEqual(true, item.HasProperName);
            Assert.AreEqual("Целостность данных и свойства", item.ProperName);

        }

        [TestMethod]
        public void TryFolder()
        {
            var item = SlnFileReader.ParseProjectInfo(@"Project(""{2150E333-8FDC-42A3-9474-1A3956D46DE8}"") = ""Модуль 3 - Автоматическое тестирование"", ""Модуль 3 - Автоматическое тестирование"", ""{90895662-C9A5-485F-AAAC-BB84EC07B8B9}""");

            Assert.AreEqual("90895662-C9A5-485F-AAAC-BB84EC07B8B9", item.Guid);
            Assert.AreEqual("Модуль 3 - Автоматическое тестирование", item.FullName);

            Assert.AreEqual(false, item.IsProject);
            
            Assert.AreEqual(true, item.HasProperName);
            Assert.AreEqual("Автоматическое тестирование", item.ProperName);

        }

        [TestMethod]
        public void TryNonstandardProject()
        {
            var item = SlnFileReader.ParseProjectInfo(@"Project(""{FAE04EC0-301F-11D3-BF4B-00C04F79EFBC}"") = ""Library"", ""Lecture31.Library\Library.csproj"", ""{0F31E012-294C-419F-B7C4-DB055B047E6F}""");

            Assert.AreEqual("0F31E012-294C-419F-B7C4-DB055B047E6F", item.Guid);
            Assert.AreEqual("Library", item.FullName);

             Assert.AreEqual(true, item.IsProject);
             Assert.AreEqual(@"Lecture31.Library\Library.csproj", item.ProjectFile.ToString());


             Assert.AreEqual(false, item.HasProperName);
        }
    }
}
