using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using static ComplexityDemo.DemoHighComplexity;

namespace ComplexityDemo.Tests
{
    public class DemoLowComplexityTests
    {

        [Fact]
        public void LowComplexityFunction_ValidatesEntities_Param1IsYes_HandlesYesAndReturnsResultsOf()
        {
            // arrange
            Mock<DemoRepo> repo = new Mock<DemoRepo>();
            Mock<DemoLowComplexity> mock= new Mock<DemoLowComplexity>();
            mock.Setup(x => x.ValidateEntities(repo.Object));
            mock.Setup(x => x.HandleYes(It.IsAny<Param2>())).Returns(3);

            // act
            var result = mock.Object.LowComplexityFunction(repo.Object, Param1.Yes, Param2.A);

            // assert
            mock.Verify(x => x.ValidateEntities(repo.Object));
            mock.Verify(x => x.HandleYes(Param2.A));
            Assert.Equal(3, result);
        }

        [Fact]
        public void LowComplexityFunction_ValidatesEntities_Param1IsNo_HandlesNoAndReturnsResultsOf()
        {
            // arrange
            Mock<DemoRepo> repo = new Mock<DemoRepo>();
            Mock<DemoLowComplexity> mock = new Mock<DemoLowComplexity>();
            mock.Setup(x => x.ValidateEntities(repo.Object));
            mock.Setup(x => x.HandleNo(It.IsAny<Param2>())).Returns(3);

            // act
            var result = mock.Object.LowComplexityFunction(repo.Object, Param1.No, Param2.A);

            // assert
            mock.Verify(x => x.ValidateEntities(repo.Object));
            mock.Verify(x => x.HandleNo(Param2.A));
            Assert.Equal(3, result);
        }

        [Fact]
        public void ValidateEntities_ClientIsNull_ThrowsException()
        {
            // arrange
            Mock<DemoRepo> repo = new Mock<DemoRepo>();
            repo.Setup(x => x.GetClient());

            // act - assert
            Assert.Throws<EntityNotFoundException<Client>>(() => new DemoLowComplexity().ValidateEntities(repo.Object));
        }

        [Fact]
        public void ValidateEntities_UserIsNull_ThrowsException()
        {
            // arrange
            Mock<DemoRepo> repo = new Mock<DemoRepo>();
            repo.Setup(x => x.GetClient()).Returns(new Client());
            repo.Setup(x => x.GetUser());

            // act - assert
            Assert.Throws<EntityNotFoundException<User>>(() => new DemoLowComplexity().ValidateEntities(repo.Object));
        }

        [Fact]
        public void ValidateEntities_PlanIsNull_ThrowsException()
        {
            // arrange
            Mock<DemoRepo> repo = new Mock<DemoRepo>();
            repo.Setup(x => x.GetClient()).Returns(new Client());
            repo.Setup(x => x.GetUser()).Returns(new User());
            repo.Setup(x => x.GetPlan());

            // act - assert
            Assert.Throws<EntityNotFoundException<Plan>>(() => new DemoLowComplexity().ValidateEntities(repo.Object));
        }

        [Fact]
        public void HandleYes_Param2IsA_Returns1()
        {
            // arrange - act
            var result = new DemoLowComplexity().HandleYes(Param2.A);

            // assert
            Assert.Equal(1, result);
        }

        [Fact]
        public void HandleYes_Param2IsB_Returns2()
        {
            // arrange - act
            var result = new DemoLowComplexity().HandleYes(Param2.B);

            // assert
            Assert.Equal(2, result);
        }

        [Fact]
        public void HandleNo_Param2IsA_Returns3()
        {
            // arrange - act
            var result = new DemoLowComplexity().HandleNo(Param2.A);

            // assert
            Assert.Equal(3, result);
        }

        [Fact]
        public void HandleNo_Param2IsB_Returns4()
        {
            // arrange - act
            var result = new DemoLowComplexity().HandleNo(Param2.B);

            // assert
            Assert.Equal(4, result);
        }
    }
}
