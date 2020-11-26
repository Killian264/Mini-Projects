using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Xunit.Sdk;
using CSC470_P3;


namespace UnitTestAppUserFakeRepository
{
    [TestClass]
    public class Login
    {
        [TestMethod]
        public void LoginWithCorrectCredentialsSuccessful()
        {
            // Arrange
            FakeAppUserRepository UserRepository = new FakeAppUserRepository();
            string correctUserName = "John240", correctPassword = "password123";

            // Act
            bool loginAttemptResult = UserRepository.Login(correctUserName, correctPassword);

            // Assert
            Assert.IsTrue(loginAttemptResult);
        }

        [TestMethod]
        public void LoginWithIncorrectCredentialsFail()
        {
            // Arrange
            FakeAppUserRepository UserRepository = new FakeAppUserRepository();
            string correctUserName = "John240", incorrectPassword = "password";

            // Act
            bool loginAttemptResult = UserRepository.Login(correctUserName, incorrectPassword);

            // Assert
            Assert.IsTrue(!loginAttemptResult);
        }
    }
}
