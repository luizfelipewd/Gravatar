using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Gravatar.Tests
{
    [TestClass]
    public class GravatarExtensionTests
    {
        [TestCategory("Gravatar Tests")]
        [TestMethod("Should Validate Gravatar Extension")]

        [DataRow(null, 200, false)]
        [DataRow("", 200, false)]
        [DataRow("a@b", 200, false)]
        [DataRow("teste@email.com", 200, false)]
        [DataRow("luizfelipewd@hotmail.com", null, true)]
        [DataRow("luizfelipewd@hotmail.com", 200, true)]

        public void ShouldValidateGravatar(string email, int? size, bool status)
        {
            var imageSize = size.HasValue ? size.Value.ToString() : "80";
            var result = $"https://www.gravatar.com/avatar/854fb6d434c4a53448093361c82d5e07?s={imageSize}";
            Assert.AreEqual(email.ToGravatar(size ?? 80) == result, status);
        }
    }
}
