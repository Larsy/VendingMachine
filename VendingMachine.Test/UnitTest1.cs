using System;
using Xunit;
using Xunit.Abstractions;

namespace VendingMachine.Test
{
    public class VendingMachineTest
    {
        private readonly ITestOutputHelper output;

        public VendingMachineTest(ITestOutputHelper output)
        {
            this.output = output;
        }

        [Fact]
        public void Test1()
        {
            //Arrange
            ushort balanceBefore = 0;
            ushort balanceAfter;
            string reply1;
            string reply2;
            string reply3;
            string reply4;
            string reply5;
            string reply6;
            string reply7;

            //Act
            IVending machine = new VendingMachine();
            reply1 = machine.InsertMoney(1);
            reply2 = machine.InsertMoney(5);
            reply3 = machine.InsertMoney(10);
            reply4 = machine.InsertMoney(20);
            reply5 = machine.InsertMoney(50);
            reply6 = machine.InsertMoney(100);
            reply7 = machine.InsertMoney(500);
            output.WriteLine("This is output from {0}", reply1);
            output.WriteLine("This is output from {0}", reply2);
            output.WriteLine("This is output from {0}", reply3);
            output.WriteLine("This is output from {0}", reply4);
            output.WriteLine("This is output from {0}", reply5);
            output.WriteLine("This is output from {0}", reply6);
            output.WriteLine("This is output from {0}", reply7);
            balanceAfter = machine.Balance;

            //Assert
            Assert.Equal(686, balanceAfter);

        }
    }
}
