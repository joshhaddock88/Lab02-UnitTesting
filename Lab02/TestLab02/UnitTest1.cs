using System;
using Lab02;
using Xunit;

namespace TestLab02
{
    public class UnitTest1
    {
        [Fact]
        public void CanReturnBalance()
        {
            Assert.Equal(Program.Balance, Program.ViewBalance());
        }

        [Fact]
        public void WithdrawExceptionReturnsNegative1()
        {
            Assert.Equal(-1M, Program.Withdraw(120M));
        }

        [Fact]
        public void WithdrawReturnsBalance()
        {
            Assert.Equal(75.00M, Program.Withdraw(25));
        }

        [Fact]
        public void DepositExceptionReturnsNegative1()
        {
            Assert.Equal(-1M, Program.Deposit(-2M));
        }

        [Fact]
        public void DepositReturnsBalance()
        {
            Assert.Equal(100.00M, Program.Deposit(25));
        }
    }
}
