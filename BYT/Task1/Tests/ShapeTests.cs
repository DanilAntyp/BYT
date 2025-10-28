using Tut2_s31371;

namespace BYT.Task1
{
    [TestFixture]
    public class ShapeTests
    {
        private IShape cylinder;
        private IShape sphere;
        private IShape cube;
        private IShape rectangle;

        [SetUp]
        public void SetUp()
        {
            cylinder = new Cylinder(3, 5);
            sphere = new Sphere(5);
            cube = new Cube(4);
            rectangle = new Rectangle(4, 8);
        }

        
        // Sphere tests
        [Test]
        public void TestSphereCalculateArea()
        {
            Assert.That(sphere.CalculateArea(), Is.EqualTo(314.159).Within(0.001));
        }

        [Test]
        public void TestSphereCalculateVolume()
        {
            Assert.That(sphere.CalculateVolume(), Is.EqualTo(523.598).Within(0.001));
        }
        
        //Cylinder tests
        [Test]
        public void TestCylinderCalculatedArea()
        {
            Assert.That(cylinder.CalculateArea(), Is.EqualTo(150.796).Within(0.001));
        }
        
        [Test]
        public void TestCylinderCalculatedVolume()
        {
            Assert.That(cylinder.CalculateVolume(), Is.EqualTo(141.3).Within(0.1));
        }
        
        //Cube tests
        
        [Test]
        public void TestCubeCalculatedArea()
        {
            Assert.That(cube.CalculateArea(), Is.EqualTo(96).Within(0.001));
        }
        
        [Test]
        public void TestCubeCalculatedVolume()
        {
            Assert.That(cube.CalculateVolume(), Is.EqualTo(64).Within(0.001));
        }
        
        //Rectangle tests

        [Test]
        public void TestRectangleCalculatedArea()
        {
            Assert.That(rectangle.CalculateArea(), Is.EqualTo(32).Within(0.001));
        }
        
        [Test]
        public void TestRectangleCalculatedVolume()
        {
            Assert.That(rectangle.CalculateVolume(), Is.EqualTo(0));
        }
    }
}