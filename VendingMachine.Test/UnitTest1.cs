using System;
using Xunit;
using Xunit.Abstractions;
using VendingMachine.Model;

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
            reply1 = MachineCoreFuncs.InsertMoney(1);
            reply2 = MachineCoreFuncs.InsertMoney(5);
            reply3 = MachineCoreFuncs.InsertMoney(10);
            reply4 = MachineCoreFuncs.InsertMoney(20);
            reply5 = MachineCoreFuncs.InsertMoney(50);
            reply6 = MachineCoreFuncs.InsertMoney(200);
            reply7 = MachineCoreFuncs.InsertMoney(500);
            output.WriteLine("This is output from {0}", reply1);
            output.WriteLine("This is output from {0}", reply2);
            output.WriteLine("This is output from {0}", reply3);
            output.WriteLine("This is output from {0}", reply4);
            output.WriteLine("This is output from {0}", reply5);
            output.WriteLine("This is output from {0}", reply6);
            output.WriteLine("This is output from {0}", reply7);
            balanceAfter = MachineCoreFuncs.Balance;

            //Assert
            Assert.Equal(686, balanceAfter);

        }
    }
}
