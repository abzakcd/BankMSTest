namespace BankAccountTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestDeposit1()
        {
            BankAccount b1 = new BankAccount("Yeenal", 3000, -1000);
            b1.Deposit(1000);
            double expected = 4000;

            Assert.AreEqual(b1.Balance, expected);
        }

        [TestMethod]
        public void TestDeposit2()
        {
            BankAccount b2 = new BankAccount("Ayala", 3000, -1000);
            
        //    double expected = 3000;
        try
        {
            b2.Withdraw(-2000);
        }
        catch(Exception e)
        {
            StringAssert.Contains(e.Message,BankAccount.WithdrawAmountNegative);
        }
                   

        //    Assert.AreEqual(b2.Balance, expected);
        }

        [TestMethod]
        public void TestDeposit3()
        {
            BankAccount b3 = new BankAccount("Nati", 3000, -1000);
            try
            {
                b3.Withdraw(9000);
            }
            catch(Exception e)
            {
                StringAssert.Contains(e.Message, BankAccount.OverOverdraft);
            }
            double expected = 1000;

        //    Assert.AreEqual(b3.Balance, expected);
        }

        [TestMethod]
        public void TestDeposit4()
        {
            BankAccount b4 = new BankAccount("Weaam", 3000, -1000);

            //    double expected = 3000;
            try
            {
                b4.Deposit(-2000);
            }
            catch(Exception e)
            {
                StringAssert.Contains(e.Message, BankAccount.DepositeAmountNegative);
            }
        //    Assert.AreEqual(b4.Balance, expected);
        }

    }
}