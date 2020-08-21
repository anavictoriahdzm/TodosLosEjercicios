using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EmailWatcher;

namespace Email.UnitTests
{
    [TestClass]
    public class WatcherEmailTests
    {
        [TestMethod]
        public void SendEmail()
        {
            //Arrange
            var mail = new Mails();

            //Act
            var result = mail.watcher_Renamed(new object { mmgs = true });

            //Assert
            Assert.IsNotNull(result);
        }
    }
}
