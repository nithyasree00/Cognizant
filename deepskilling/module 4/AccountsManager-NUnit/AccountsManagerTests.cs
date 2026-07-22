using NUnit.Framework;
using System;
using AccountsManagerLib;

namespace AccountsManagerLib.Tests
{
    [TestFixture]
    public class AccountsManagerTests
    {
        private AccountsManager account;

        [SetUp]
        public void Setup()
        {
            account = new AccountsManager();
        }

        [Test]
        public void Login_ValidUser11_ReturnsWelcomeMessage()
        {
            string result = account.Login("user_11", "secret@user11");

            Assert.That(result, Is.EqualTo("Welcome user_11!!!"));
        }

        [Test]
        public void Login_ValidUser22_ReturnsWelcomeMessage()
        {
            string result = account.Login("user_22", "secret@user22");

            Assert.That(result, Is.EqualTo("Welcome user_22!!!"));
        }

        [Test]
        public void Login_InvalidCredentials_ReturnsInvalidMessage()
        {
            string result = account.Login("user_33", "password");

            Assert.That(result, Is.EqualTo("Invalid user id/password"));
        }

        [Test]
        public void Login_EmptyUserId_ThrowsArgumentException()
        {
            Assert.That(
                () => account.Login("", "secret@user11"),
                Throws.TypeOf<ArgumentException>());
        }

        [Test]
        public void Login_EmptyPassword_ThrowsArgumentException()
        {
            Assert.That(
                () => account.Login("user_11", ""),
                Throws.TypeOf<ArgumentException>());
        }
    }
}