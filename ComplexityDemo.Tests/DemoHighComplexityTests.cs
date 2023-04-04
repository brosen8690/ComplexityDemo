using Moq;
using Xunit;

namespace ComplexityDemo.Tests
{
    public class DemoHighComplexityTests
    {
        [Fact]
        public void HighComplexityFunction_ClientIsNull_ThrowsException()
        {
            // arrange
            Mock<DemoRepo> repo = new Mock<DemoRepo>();
            Mock<DemoHighComplexity> mock = new Mock<DemoHighComplexity>();
            repo.Setup(x => x.GetClient());

            // act - assert
            Assert.Throws<EntityNotFoundException<Client>>(() => mock.Object.HighComplexityFunction(repo.Object, DemoHighComplexity.Param1.Yes, DemoHighComplexity.Param2.A));
        }

        [Fact]
        public void HighComplexityFunction_UserIsNull_ThrowsException()
        {
            // arrange
            Mock<DemoRepo> repo = new Mock<DemoRepo>();
            Mock<DemoHighComplexity> mock = new Mock<DemoHighComplexity>();
            repo.Setup(x => x.GetClient()).Returns(new Client());
            repo.Setup(x => x.GetUser());

            // act - assert
            Assert.Throws<EntityNotFoundException<User>>(() => mock.Object.HighComplexityFunction(repo.Object, DemoHighComplexity.Param1.Yes, DemoHighComplexity.Param2.A));
        }

        [Fact]
        public void HighComplexityFunction_PlanIsNull_ThrowsException()
        {
            // arrange
            Mock<DemoRepo> repo = new Mock<DemoRepo>();
            Mock<DemoHighComplexity> mock = new Mock<DemoHighComplexity>();
            repo.Setup(x => x.GetClient()).Returns(new Client());
            repo.Setup(x => x.GetUser()).Returns(new User());
            repo.Setup(x => x.GetPlan());

            // act - assert
            Assert.Throws<EntityNotFoundException<Plan>>(() => mock.Object.HighComplexityFunction(repo.Object, DemoHighComplexity.Param1.Yes, DemoHighComplexity.Param2.A));
        }

        [Fact]
        public void HighComplexityDemo_Param1IsYes_Param2IsA_Returns1()
        {
            // arrange
            Mock<DemoRepo> repo = new Mock<DemoRepo>();
            Mock<DemoHighComplexity> mock = new Mock<DemoHighComplexity>();
            repo.Setup(x => x.GetClient()).Returns(new Client());
            repo.Setup(x => x.GetUser()).Returns(new User());
            repo.Setup(x => x.GetPlan()).Returns(new Plan());

            // act
            var result = mock.Object.HighComplexityFunction(repo.Object, DemoHighComplexity.Param1.Yes, DemoHighComplexity.Param2.A);

            // assert
            Assert.Equal(1, result);
        }

        [Fact]
        public void HighComplexityDemo_Param1IsYes_Param2IsB_Returns2()
        {
            // arrange
            Mock<DemoRepo> repo = new Mock<DemoRepo>();
            Mock<DemoHighComplexity> mock = new Mock<DemoHighComplexity>();
            repo.Setup(x => x.GetClient()).Returns(new Client());
            repo.Setup(x => x.GetUser()).Returns(new User());
            repo.Setup(x => x.GetPlan()).Returns(new Plan());

            // act
            var result = mock.Object.HighComplexityFunction(repo.Object, DemoHighComplexity.Param1.Yes, DemoHighComplexity.Param2.B);

            // assert
            Assert.Equal(2, result);
        }

        [Fact]
        public void HighComplexityDemo_Param1IsNo_Param2IsA_Returns3()
        {
            // arrange
            Mock<DemoRepo> repo = new Mock<DemoRepo>();
            Mock<DemoHighComplexity> mock = new Mock<DemoHighComplexity>();
            repo.Setup(x => x.GetClient()).Returns(new Client());
            repo.Setup(x => x.GetUser()).Returns(new User());
            repo.Setup(x => x.GetPlan()).Returns(new Plan());

            // act
            var result = mock.Object.HighComplexityFunction(repo.Object, DemoHighComplexity.Param1.No, DemoHighComplexity.Param2.A);

            // assert
            Assert.Equal(3, result);
        }

        [Fact]
        public void HighComplexityDemo_Param1IsNo_Param2IsB_Returns4()
        {
            // arrange
            Mock<DemoRepo> repo = new Mock<DemoRepo>();
            Mock<DemoHighComplexity> mock = new Mock<DemoHighComplexity>();
            repo.Setup(x => x.GetClient()).Returns(new Client());
            repo.Setup(x => x.GetUser()).Returns(new User());
            repo.Setup(x => x.GetPlan()).Returns(new Plan());

            // act
            var result = mock.Object.HighComplexityFunction(repo.Object, DemoHighComplexity.Param1.No, DemoHighComplexity.Param2.B);

            // assert
            Assert.Equal(4, result);
        }
    }
}