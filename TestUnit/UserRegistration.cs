using Xunit;

namespace TestUnit
{
    public class UserRegistration
    {
        [Fact]
        public void TestForFirstName()
        {
            string name = RegexPattern.Name("chetan");
            Assert.Equal("chetan", name);
        }
        [Fact]
        public void TestForNull()
        {
            string name = RegexPattern.Name("");
            Assert.Equal(null, name);
        }
        [Fact]
        public void TestForLastName()
        {
            string lName = RegexPattern.Name("choudhari");
            Assert.Equal("choudhari", lName);
        }
        [Fact]
        public void TestNull()
        {
            string name = RegexPattern.Name("");
            Assert.Equal(null, name);
        }
        [Fact]
        public void TestNumber()
        {
            long pNum = 8899007799;
            long num = RegexPattern.PhoneNumber(pNum);
            Assert.Equal(pNum, num);
        }
        [Fact]
        public void TestNumberNull()
        {
            long pNumber = 000;
            long actualNumber = RegexPattern.PhoneNumber(pNumber);
            Assert.Equal(0, actualNumber);
        }
        [Fact]
        public void TestEmail()
        {
            string email = "cheta.c@gmail.com";
            string actualEmail = RegexPattern.Email(email);
            Assert.Equal(email, actualEmail);
        }
        public void TestEmailNull()
        {
            string email = "";
            string actualEmail = RegexPattern.Email(email);
            Assert.Equal(null, actualEmail);
        }
        [Fact]
        public void TestPassword()
        {
            string password = "Chet@0987";
            string actualPassword = RegexPattern.Password(password);
            Assert.Equal(password, actualPassword);
        }
        public void TestPasswordNull()
        {
            string password = "";
            string actualPassword = RegexPattern.Password(password);
            Assert.Equal(null, actualPassword);
        }
    }
}
