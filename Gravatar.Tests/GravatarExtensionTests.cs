using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Gravatar.Tests
{
    [TestClass]
    public class GravatarExtensionTests
    {
        [TestCategory("Gravatar Tests")]
        [TestMethod("Should Validate Gravatar Extension")]

        [DataRow(null, false)]
        [DataRow("", false)]
        [DataRow("a@b", false)]
        [DataRow("teste@email.com", false)]
        [DataRow("luizfelipewd@hotmail.com", true)]

        public void ShouldValidateGravatar(string email, bool status)
        {
            var result = "https://www.gravatar.com/avatar/854fb6d434c4a53448093361c82d5e07";
            Assert.AreEqual(email.ToGravatar() == result, status);
        }
    }
}
