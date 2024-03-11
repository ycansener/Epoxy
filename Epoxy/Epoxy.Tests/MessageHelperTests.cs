namespace Epoxy.Tests
{
    [TestFixture]
    public class MessageHelperTests
    {
        private Mock<IMessageHelper> messageHelper;

        [SetUp]
        public void Setup()
        {
            messageHelper = new Mock<IMessageHelper>();
        }
    }
}
