﻿using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MigrationTools.Services.Tests
{
    [TestClass()]
    public class DetectVersionServiceTests
    {
        [TestMethod()]
        public void DetectVersionServiceTest()
        {
            var dos = new DetectVersionService(new TelemetryLoggerMock());
            var result = dos.GetLatestVersion();
            Assert.IsNotNull(result);
        }
    }
}