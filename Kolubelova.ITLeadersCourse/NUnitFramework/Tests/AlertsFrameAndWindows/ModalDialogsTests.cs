﻿using NUnit.Framework;
using NUnitFramework.Navigation.LeftPanel;

namespace NUnitFramework.Tests.AlertsFrameAndWindows
{
    public class ModalDialogsTests : BaseTest
    {
        [Test]
        [TestCase("Small Modal", "This is a small modal.")]
        public void SmallModalTest(string expectedHeader, string expectedMessage)
        {
            var modalDialogsPage = LeftPanel.AlertsFrameAndWindows.ModalDialogs();

            var smallModal = modalDialogsPage.ClickOnSmallModalButton();

            var actualHeader = smallModal.GetHeader();
            var actualMessage = smallModal.GetMessage();

            smallModal.CloseDialog();

            Assert.Multiple(() =>
            {
                Assert.That(actualHeader, Is.EqualTo(expectedHeader), "Wrong headers");
                Assert.That(actualMessage, Does.Contain(expectedMessage), "Wrong messages");
            });
        }
    }
}
