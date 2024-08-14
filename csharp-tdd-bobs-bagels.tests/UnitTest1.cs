
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
    [TestCase ("HamBagel", false)]
    public void AddBagelTest(string bagel, bool expected)
    {
        List<string> bagels = new List<string> ();
        bagels.Capacity = 2;
        Basket core = new Basket();

        bool actual = core.AddBagel(bagel);
        
        Assert.That(expected, Is.EqualTo(actual));
    }

    [Test]
    public void RemoveBagelTest()
    {
        List<string> bagels = new List<string>();
        bagels.Add("Bagel");
        bagels.Add("ChocolateBagel");

        Basket basket = new Basket();

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
        Basket basket = new Basket();
        List<string> bagels = new List<string>();
        int expectedCapacity = capacity;

        int actualCapacity = basket.changeCapacity(capacity);

        Assert.That(actualCapacity, Is.EqualTo(expectedCapacity));
    }
}