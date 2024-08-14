
using tdd_bobs_bagels.CSharp.Main;
namespace csharp_tdd_bobs_bagels.tests;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [TestCase ("Bagel", true)]
    [TestCase ("ChocolateBagel", true)]
    [TestCase ("HamBagel", true)]
    public void AddBagelTest(string bagel, bool expected)
    {
        List<string> bagels = new List<string> ();
       
        Basket basket = new Basket(2, bagels);
        
        bool added1 = basket.AddBagel("Bagel");
        bool added2 = basket.AddBagel("ChocolateBagel");
        bool added3 = basket.AddBagel("HamBagel");
        
        Assert.That(true, Is.EqualTo(added1));
        Assert.That(true, Is.EqualTo(added2));
        Assert.That(false, Is.EqualTo(added3));
    }

    [Test]
    public void RemoveBagelTest()
    {
        int maxCapacity = 10;
        List<string> bagels = new List<string>();
        bagels.Add("Bagel");
        bagels.Add("ChocolateBagel");

        Basket basket = new Basket(maxCapacity,bagels);

        string bagel1 = "Bagel"; 
        string bagel2 = "ChocolateBagel"; 
        string bagel3 = "HamBagel"; 
        bool removed1 = basket.removeBagel(bagel1);
        bool removed2 = basket.removeBagel(bagel2);
        bool removed3 = basket.removeBagel(bagel3);

        Assert.That(removed1, Is.EqualTo(true));
        Assert.That(removed2, Is.EqualTo(true));
        Assert.That(removed3, Is.EqualTo(false));
    }

    [TestCase (3)]
    [TestCase (4)]
    [TestCase (1)]
    [TestCase (5)]
    public void changeCapacity(int capacity)
    {
        List<string> bagels = new List<string>();
        Basket basket = new Basket(capacity, bagels);
        int expectedCapacity = capacity;

        int actualCapacity = basket.changeCapacity(capacity);

        Assert.That(actualCapacity, Is.EqualTo(expectedCapacity));
    }
}